using System;
using NotificationSystem.Models;

namespace NotificationSystem.Notifiers
{
    public class SMSNotifier
    {
        public void HandleNotification(object sender, NotificationEventArgs e)
        {
            Console.WriteLine($"[SMS] To: {e.RecipientName}");
            Console.WriteLine($"[SMS] Message: {e.Message}");
            Console.WriteLine($"[SMS] Sent at: {e.Timestamp}");
            Console.WriteLine();
        }
    }
}