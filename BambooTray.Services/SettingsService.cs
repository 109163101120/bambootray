using System.Linq;
using BambooTray.Domain.Settings;

namespace BambooTray.Services
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;

    public class SettingsService : ISettingsService
    {
        private readonly string _settingsPath;

        public SettingsService(string settingsPath)
        {
            _settingsPath = settingsPath;

            if (!File.Exists(settingsPath))
            {
                TraySettings = new TraySettings();
            }
            else
            {
                var serializer = new XmlSerializer(typeof(TraySettings));
                using (var streamReader = new StreamReader(settingsPath))
                    TraySettings = (TraySettings)serializer.Deserialize(streamReader);
            }

            if (TraySettings.Version == 0)
            {
                TraySettings.Version = 1;
                TraySettings.BalloonNotifications = Enum.GetValues(typeof(NotificationType)).Cast<NotificationType>().Where(e => e != NotificationType.Succesfull).ToList();
                TraySettings.SpeechNotifications = Enum.GetValues(typeof(NotificationType)).Cast<NotificationType>().Where(e => e != NotificationType.Succesfull).ToList();
                SaveTraySettings();
            }
        }

        public TraySettings TraySettings { get; set; }
     
        public bool SaveTraySettings()
        {
            var serializer = new XmlSerializer(typeof(TraySettings));
            using (var streamWriter = new StreamWriter(_settingsPath))
            {
                serializer.Serialize(streamWriter, TraySettings);
            }

            return true;
        }

        public TraySettings CreateCopy()
        {
            TraySettings original = TraySettings;

            var copy = new TraySettings
            {
                PollTime = original.PollTime,
                AnimatedBuildIcon = original.AnimatedBuildIcon,

                EnableBalloonNotifications = original.EnableBalloonNotifications,
                BalloonToolTipTimeOut = original.BalloonToolTipTimeOut,
                BalloonNotifications = new List<NotificationType>(original.BalloonNotifications),

                EnableSpeechNotifications = original.EnableSpeechNotifications,
                SpeechNotifications = new List<NotificationType>(original.SpeechNotifications),
                SpeechNotificationVoice = original.SpeechNotificationVoice.ToString(),

                DisplayParameters = original.DisplayParameters?.Clone() as byte[],
            };

            foreach (var originalServer in original.Servers)
            {
                var newServer = new Server()
                {
                    Id = originalServer.Id,
                    Address = originalServer.Address,
                    Name = originalServer.Name,
                    Username = originalServer.Username,
                    Password = originalServer.Password
                };

                newServer.BuildPlans.AddRange(originalServer.BuildPlans.Select(p => new BuildPlan() {Key = p.Key}));

                copy.Servers.Add(newServer);
            }

            return copy;
        }
    }
}
