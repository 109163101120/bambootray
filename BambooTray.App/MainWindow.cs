using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BambooTray.App.Models;
using BambooTray.App.Properties;
using BambooTray.Services;
using BrightIdeasSoftware;
using BambooTray.Domain.Settings;

namespace BambooTray.App
{
    /// <summary>
    /// Main Window
    /// </summary>
    public partial class MainWindow : Form
    {
        private readonly ISettingsService _settingsService;

        private readonly List<Icon> _buildingIcons;

        private readonly Dictionary<IconEnum, Icon> _statusIcons = new Dictionary<IconEnum, Icon>();

        private int _currentBuildIcon;

        private bool _applicationIsExiting;

        private List<MainViewModel> _lastBuildData;

        private SpeechController _speech;

        private enum IconEnum
        {
            Grey,
            Red,
            Green,
            Blue,
            Yellow1,
            Yellow2,
            Yellow3,
            Yellow4
        };

        public MainWindow(ISettingsService settingsService)
        {
            InitializeComponent();
            _settingsService = settingsService;

            _buildingIcons = new List<Icon>();
            _buildingIcons = GetBuildingIcons(4);

            _statusIcons = new Dictionary<IconEnum, Icon>
            {
                {IconEnum.Grey, Icon.FromHandle(Resources.BambooGrey.GetHicon())},
                {IconEnum.Red, Icon.FromHandle(Resources.BambooRed.GetHicon())},
                {IconEnum.Green, Icon.FromHandle(Resources.BambooGreen.GetHicon())},
            };

            notifyIcon.Icon = _statusIcons[IconEnum.Grey];

            _speech = new SpeechController();

            _lastBuildData = new List<MainViewModel>();
            buildsListView.SmallImageList = GetListViewImages();
            if(_settingsService.TraySettings?.DisplayParameters?.Length >0)
                buildsListView.RestoreState(_settingsService.TraySettings.DisplayParameters);

            var refreshBuildsTask = new RefreshBuildsTask(_settingsService, RefreshView, NotifyConnectionError);
            refreshBuildsTask.Run();
        }

        private static ImageList GetListViewImages()
        {
            var imageList = new ImageList();
            imageList.Images.Add("Successful", Resources.BambooGreen);
            imageList.Images.Add("Failed", Resources.BambooRed);
            imageList.Images.Add("Building", Resources.BambooYellow1);
            imageList.Images.Add("Offline", Resources.BambooGrey);
            return imageList;
        }

        private static List<Icon> GetBuildingIcons(int numberOfIcons)
        {
            var icons = new List<Icon>();
            for (var i = 1; i < numberOfIcons+1; i++)
            {
                var bitmap = Resources.ResourceManager.GetObject("BambooYellow" + i) as Bitmap;
                if (bitmap != null)
                {
                    icons.Add(Icon.FromHandle(bitmap.GetHicon()));
                }
            }

            return icons;
        }

        private void RefreshView(List<MainViewModel> viewModels)
        {
            using (new PreserveSelectedItemGuard(buildsListView))
            {
                RefreshListView(viewModels);
                DoNotifications(viewModels);
                UpdateTrayIcon(viewModels);
                _lastBuildData = viewModels;
            }
        }

        private void UpdateTrayIcon(IEnumerable<MainViewModel> currentBuildData)
        {
            var building = false;
            var broken = false;
            foreach (var plan in currentBuildData)
            {
                if (plan.BuildActive)
                {
                    building = true;
                }

                if (plan.BuildBroken)
                {
                    broken = true;
                }
            }

            iconTimer.Enabled = building;

            if (!building)
            {
                if (broken)
                    notifyIcon.Icon = _statusIcons[IconEnum.Red];
                else
                    notifyIcon.Icon = _statusIcons[IconEnum.Green];
            }
        }

        private void DoNotifications(IEnumerable<MainViewModel> currentBuildData)
        {
            List<NotificationModel> notifications = new List<NotificationModel>();

            foreach (var currentBuild in currentBuildData)
            {
                var lastBuild = _lastBuildData.FirstOrDefault(x => x.PlanKey == currentBuild.PlanKey);
                if (lastBuild != null)
                {
                    if (lastBuild.BuildActive && !currentBuild.BuildActive)
                    {
                        // Build Status has just changed... 
                        if (lastBuild.BuildBroken && !currentBuild.BuildBroken)
                        {
                            notifications.Add(new NotificationModel( $"{currentBuild.PlanName}: Fixed!",
                                "Recent checkins have fixed the build.",
                                ToolTipIcon.Info,
                                NotificationType.Fixed));
                        }
                        else if (!lastBuild.BuildBroken && currentBuild.BuildBroken)
                        {
                            notifications.Add(new NotificationModel($"{currentBuild.PlanName}: Broken!",
                                "Recent checkins have broken the build.",
                                ToolTipIcon.Error,
                                NotificationType.Broken));
                        }
                        else if (!lastBuild.BuildBroken && !currentBuild.BuildBroken)
                        {
                            notifications.Add(new NotificationModel($"{currentBuild.PlanName}: Build Successful!",
                                "Yet another successful build.",
                                ToolTipIcon.Info,
                                NotificationType.Succesfull));
                        }
                        else if (lastBuild.BuildBroken && currentBuild.BuildBroken)
                        {
                            notifications.Add(new NotificationModel($"{currentBuild.PlanName}: Broken!",
                                "The build is still broken.",
                                ToolTipIcon.Error,
                                NotificationType.RemainingBroken));
                        }
                    }
                }
            }

            foreach (var item in notifications)
            {
                if (_settingsService.TraySettings.EnableBalloonNotifications && _settingsService.TraySettings.BalloonNotifications.Contains(item.Type))
                    notifyIcon.ShowBalloonTip(_settingsService.TraySettings.BalloonToolTipTimeOut, item.Caption, item.Message, item.Level);

                if (_settingsService.TraySettings.EnableSpeechNotifications && _settingsService.TraySettings.SpeechNotifications.Contains(item.Type))
                {
                    _speech.SelectedVoice = _settingsService.TraySettings.SpeechNotificationVoice;
                    _speech.Play(item.Caption.Substring(0, item.Caption.IndexOf(':')) + " reports " + item.Message);
                }
            }
        }

        private void NotifyConnectionError(Exception e)
        {
            iconTimer.Enabled = false;

            Icon greyIcon = _statusIcons[MainWindow.IconEnum.Grey];
            bool showBallonTip = notifyIcon.Icon != greyIcon;
            notifyIcon.Icon = greyIcon;

            if(buildsListView.Objects != null)
                foreach (object item in buildsListView.Objects)
                    if (item is MainViewModel && item != null)
                        (item as MainViewModel).Image = "Offline";

            if (showBallonTip)
            {
                notifyIcon.ShowBalloonTip(
                    _settingsService.TraySettings.BalloonToolTipTimeOut,
                    "Server Connection Error",
                    string.Format("Unable to connect to the server. Error: \n{0}", e.Message),
                    ToolTipIcon.Error);
            }
        }

        private void RefreshListView(IEnumerable<MainViewModel> mainViewModels)
        {
            buildsListView.SetObjects(mainViewModels);
        }

        private void ListViewDoubleClick(object sender, EventArgs e)
        {
            var mainViewModel = buildsListView.SelectedObject as MainViewModel;
            if (mainViewModel != null)
                LaunchBrowser(mainViewModel.LatestResultUrl);
        }

        private void LaunchBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception e)
            {
                string msg = string.Format("Unable to view the web page.{0}{0}{1}", Environment.NewLine, e.Message);
                MessageBox.Show(msg, "Unable to Launch Browser", MessageBoxButtons.OK);
            }
        }

        private void PreferencesToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open the Preferences Window
            var preferencesWindow = new PreferencesWindow(_settingsService);
            preferencesWindow.ShowDialog(this);
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open the about Window
            var aboutBox = new AboutWindow();
            aboutBox.ShowDialog(this);
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // User has clicked Exit or Keyed ALT+F4
            _applicationIsExiting = true;
            notifyIcon.Visible = false;
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!_applicationIsExiting)
            {
                Hide();
                e.Cancel = true;
            }

            base.OnFormClosing(e);
        }

        private void NotifyIconClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // When tray icon is clicked, show main window and bring to front
                Show();
                Activate();
                BringToFront();
            }
        }

        private void BuildIconTimerTick(object sender, EventArgs e)
        {
            _currentBuildIcon++;
            if (_currentBuildIcon >= _buildingIcons.Count || !_settingsService.TraySettings.AnimatedBuildIcon)
                _currentBuildIcon = 0;

            // This isn't very nice, but to animate the tray icon when a build is in progress.
            notifyIcon.Icon = _buildingIcons[_currentBuildIcon];
        }

        private void MainWindow_Deactivate(object sender, EventArgs e)
        {
            _settingsService.TraySettings.DisplayParameters = buildsListView.SaveState();
            _settingsService.SaveTraySettings();
        }

        private void showMainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NotifyIconClick(sender, new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
        }
    }

    internal class PreserveSelectedItemGuard : IDisposable
    {
        private readonly ObjectListView _listView = null;
        private readonly List<string> _selectedKeys = new List<string>();
        private readonly string _focusedItemKey = string.Empty;

        public PreserveSelectedItemGuard(ObjectListView listView)
        {
            _listView = listView;

            if (listView.FocusedObject != null)
                _focusedItemKey = (listView.FocusedObject as MainViewModel)?.PlanKey;

            if (listView.SelectedObjects.Count > 0)
            {
                foreach (var item in listView.SelectedObjects)
                {
                    _selectedKeys.Add((item as MainViewModel)?.PlanKey);
                }
            }
        }

        public void Dispose()
        {
            List<object> itemsToSelect = new List<object>();
            foreach (var item in _listView.Objects)
            {
                var key = (item as MainViewModel)?.PlanKey;
                if (key != null && string.Equals(key, _focusedItemKey))
                    _listView.FocusedObject = item;

                if (_selectedKeys.Contains(key))
                    itemsToSelect.Add(item);
            }

            if (_selectedKeys.Count > 0)
            {
                _listView.SelectedObjects = itemsToSelect;
                itemsToSelect.ForEach(_listView.EnsureModelVisible);
            }
        }
    }
}