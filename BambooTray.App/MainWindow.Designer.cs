using BambooTray.App.Models;

namespace BambooTray.App
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buildsListView = new BrightIdeasSoftware.ObjectListView();
            this.serverColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.projectColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.planColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buildActivityColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buildStatusColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastBuildTimeColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastBuildDurationColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastBuildNumberColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastVcsRevisionColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.successfulTestCountColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.failedTestCountColumnHeader = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.iconTimer = new System.Windows.Forms.Timer(this.components);
            this.mainViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.showMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildsListView)).BeginInit();
            this.contextMenuTray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(896, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences...";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.PreferencesToolStripMenuItemClick);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // buildsListView
            // 
            this.buildsListView.AllColumns.Add(this.serverColumnHeader);
            this.buildsListView.AllColumns.Add(this.projectColumnHeader);
            this.buildsListView.AllColumns.Add(this.planColumnHeader);
            this.buildsListView.AllColumns.Add(this.buildActivityColumnHeader);
            this.buildsListView.AllColumns.Add(this.buildStatusColumnHeader);
            this.buildsListView.AllColumns.Add(this.lastBuildTimeColumnHeader);
            this.buildsListView.AllColumns.Add(this.lastBuildDurationColumnHeader);
            this.buildsListView.AllColumns.Add(this.lastBuildNumberColumnHeader);
            this.buildsListView.AllColumns.Add(this.lastVcsRevisionColumnHeader);
            this.buildsListView.AllColumns.Add(this.successfulTestCountColumnHeader);
            this.buildsListView.AllColumns.Add(this.failedTestCountColumnHeader);
            this.buildsListView.CellEditUseWholeCell = false;
            this.buildsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serverColumnHeader,
            this.projectColumnHeader,
            this.planColumnHeader,
            this.buildActivityColumnHeader,
            this.buildStatusColumnHeader,
            this.lastBuildTimeColumnHeader,
            this.lastBuildDurationColumnHeader,
            this.lastBuildNumberColumnHeader,
            this.lastVcsRevisionColumnHeader,
            this.successfulTestCountColumnHeader,
            this.failedTestCountColumnHeader});
            this.buildsListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.buildsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildsListView.FullRowSelect = true;
            this.buildsListView.Location = new System.Drawing.Point(0, 24);
            this.buildsListView.Name = "buildsListView";
            this.buildsListView.Size = new System.Drawing.Size(896, 200);
            this.buildsListView.TabIndex = 3;
            this.buildsListView.UseCompatibleStateImageBehavior = false;
            this.buildsListView.View = System.Windows.Forms.View.Details;
            this.buildsListView.DoubleClick += new System.EventHandler(this.ListViewDoubleClick);
            // 
            // serverColumnHeader
            // 
            this.serverColumnHeader.AspectName = "ServerName";
            this.serverColumnHeader.ImageAspectName = "Image";
            this.serverColumnHeader.Text = "Server";
            this.serverColumnHeader.Width = 80;
            // 
            // projectColumnHeader
            // 
            this.projectColumnHeader.AspectName = "ProjectName";
            this.projectColumnHeader.Text = "Project";
            this.projectColumnHeader.Width = 74;
            // 
            // planColumnHeader
            // 
            this.planColumnHeader.AspectName = "ShortPlanName";
            this.planColumnHeader.Text = "Plan";
            this.planColumnHeader.Width = 119;
            // 
            // buildActivityColumnHeader
            // 
            this.buildActivityColumnHeader.AspectName = "BuildActivity";
            this.buildActivityColumnHeader.AspectToStringFormat = "";
            this.buildActivityColumnHeader.Text = "Activity";
            // 
            // buildStatusColumnHeader
            // 
            this.buildStatusColumnHeader.AspectName = "BuildStatus";
            this.buildStatusColumnHeader.Text = "Status";
            this.buildStatusColumnHeader.Width = 70;
            // 
            // lastBuildTimeColumnHeader
            // 
            this.lastBuildTimeColumnHeader.AspectName = "LastBuildTime";
            this.lastBuildTimeColumnHeader.Text = "Last Build";
            this.lastBuildTimeColumnHeader.Width = 85;
            // 
            // lastBuildDurationColumnHeader
            // 
            this.lastBuildDurationColumnHeader.AspectName = "LastBuildDuration";
            this.lastBuildDurationColumnHeader.Text = "Duration";
            this.lastBuildDurationColumnHeader.Width = 80;
            // 
            // lastBuildNumberColumnHeader
            // 
            this.lastBuildNumberColumnHeader.AspectName = "LastBuildNumber";
            this.lastBuildNumberColumnHeader.Text = "Build Number";
            this.lastBuildNumberColumnHeader.Width = 80;
            // 
            // lastVcsRevisionColumnHeader
            // 
            this.lastVcsRevisionColumnHeader.AspectName = "LastVcsRevision";
            this.lastVcsRevisionColumnHeader.Text = "VCS Revision";
            this.lastVcsRevisionColumnHeader.Width = 80;
            // 
            // successfulTestCountColumnHeader
            // 
            this.successfulTestCountColumnHeader.AspectName = "SuccessfulTestCount";
            this.successfulTestCountColumnHeader.Text = "Passing Tests";
            this.successfulTestCountColumnHeader.Width = 80;
            // 
            // failedTestCountColumnHeader
            // 
            this.failedTestCountColumnHeader.AspectName = "FailedTestCount";
            this.failedTestCountColumnHeader.Text = "Failing Tests";
            this.failedTestCountColumnHeader.Width = 80;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuTray;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Bamboo Tray";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconClick);
            // 
            // contextMenuTray
            // 
            this.contextMenuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainWindowToolStripMenuItem,
            this.menuItemExit});
            this.contextMenuTray.Name = "contextMenuTray";
            this.contextMenuTray.Size = new System.Drawing.Size(193, 70);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(192, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // iconTimer
            // 
            this.iconTimer.Interval = 200;
            this.iconTimer.Tick += new System.EventHandler(this.BuildIconTimerTick);
            // 
            // mainViewModelBindingSource
            // 
            this.mainViewModelBindingSource.DataSource = typeof(BambooTray.App.Models.MainViewModel);
            // 
            // showMainWindowToolStripMenuItem
            // 
            this.showMainWindowToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.showMainWindowToolStripMenuItem.Name = "showMainWindowToolStripMenuItem";
            this.showMainWindowToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showMainWindowToolStripMenuItem.Text = "Show Status Window";
            this.showMainWindowToolStripMenuItem.Click += new System.EventHandler(this.showMainWindowToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 224);
            this.Controls.Add(this.buildsListView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Bamboo Tray";
            this.Deactivate += new System.EventHandler(this.MainWindow_Deactivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buildsListView)).EndInit();
            this.contextMenuTray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.BindingSource mainViewModelBindingSource;
        private BrightIdeasSoftware.ObjectListView buildsListView;
        private BrightIdeasSoftware.OLVColumn serverColumnHeader;
        private BrightIdeasSoftware.OLVColumn projectColumnHeader;
        private BrightIdeasSoftware.OLVColumn planColumnHeader;
        private BrightIdeasSoftware.OLVColumn buildActivityColumnHeader;
        private BrightIdeasSoftware.OLVColumn buildStatusColumnHeader;
        private BrightIdeasSoftware.OLVColumn lastBuildTimeColumnHeader;
        private BrightIdeasSoftware.OLVColumn lastBuildDurationColumnHeader;
        private BrightIdeasSoftware.OLVColumn lastBuildNumberColumnHeader;
        private BrightIdeasSoftware.OLVColumn lastVcsRevisionColumnHeader;
        private BrightIdeasSoftware.OLVColumn successfulTestCountColumnHeader;
        private BrightIdeasSoftware.OLVColumn failedTestCountColumnHeader;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer iconTimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuTray;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem showMainWindowToolStripMenuItem;
    }
}

