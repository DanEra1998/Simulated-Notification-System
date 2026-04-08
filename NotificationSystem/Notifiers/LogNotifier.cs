using System;
using NotificationSystem.Models;

namespace NotificationSystem.Notifiers
{
    public class LogNotifier
    {
        public void HandleNotification(object sender, NotificationEventArgs e)
        {
            Console.WriteLine($"[LOG] Event fired by: {sender.GetType().Name}");
            Console.WriteLine($"[LOG] Recipient: {e.RecipientName}");
            Console.WriteLine($"[LOG] Message: {e.Message}");
            Console.WriteLine($"[LOG] Timestamp: {e.Timestamp}");
            Console.WriteLine();
        }
    }
}