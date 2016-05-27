namespace BambooTray.Domain.Settings
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [Serializable]
    public enum NotificationType
    {
        Broken,
        RemainingBroken,
        Fixed,
        Succesfull,
    }

    [Serializable]
    [XmlRoot("bambooTray")]
    public class TraySettings
    {
        [XmlArray("servers")]
        [XmlArrayItem("server", typeof(Server))]
        public List<Server> Servers { get; private set; } = new List<Server>();

        [XmlAttribute("pollingtime")]
        public int PollTime { get; set; } = 20000;

        [XmlAttribute("animatedBuildIcon")]
        public bool AnimatedBuildIcon { get; set; } = true;

        [XmlAttribute("balloonNotifications")]
        public bool EnableBalloonNotifications { get; set; } = true;

        [XmlAttribute("balloonNotificationTimeout")]
        public int BalloonToolTipTimeOut { get; set; } = 2000;

        [XmlAttribute("balloonNotificationTypes")]
        public List<NotificationType> BalloonNotifications { get; set; } = null;

        [XmlAttribute("speechNotifications")]
        public bool EnableSpeechNotifications { get; set; } = true;

        [XmlAttribute("speechNotificationTypes")]
        public List<NotificationType> SpeechNotifications { get; set; } = null;

        [XmlAttribute("speechNotificationVoice")]
        public string SpeechNotificationVoice { get; set; } = string.Empty;

        [XmlAttribute("displayParam")]
        public byte[] DisplayParameters { get; set; } = null;

        [XmlAttribute("settingsVersion")]
        public int Version { get; set; } = 0;
    }
}
