using System;
using NotificationSystem.Models;

namespace NotificationSystem.Services
{
    public class NotificationService
    {
        public event EventHandler<NotificationEventArgs> OnNotificationSent; 
        public void SendNotification(string recipientName, string message)
        {
            NotificationEventArgs eventArgs = new NotificationEventArgs(recipientName, message);
            OnNotificationSent?.Invoke(this, eventArgs);
        }
    }
}