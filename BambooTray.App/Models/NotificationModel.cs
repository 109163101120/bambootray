using BambooTray.Domain.Settings;
using System.Windows.Forms;

namespace BambooTray.App.Models
{
    public class NotificationModel
    {
        public string Caption { get; private set; }
        public string Message { get; private set; }
        public ToolTipIcon Level { get; private set; }
        public NotificationType Type { get; private set; }

        public NotificationModel(string caption, string message, ToolTipIcon level, NotificationType type)
        {
            this.Caption = caption;
            this.Message = message;
            this.Level = level;
            this.Type = type;
        }
    }
}