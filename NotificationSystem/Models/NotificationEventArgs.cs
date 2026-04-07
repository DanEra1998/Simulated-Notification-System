using System;
namespace NotificationSystem.Models
{
    public class NotificationEventArgs : EventArgs
    {
        public string RecipientName {  get; set; }
        public string Message { get; set; } 
        public DateTime Timestamp { get; set; }

        public NotificationEventArgs(string recipientName, string message)
        {
            RecipientName = recipientName;
            Message = message;  
            Timestamp = DateTime.Now;

        }
    }
}