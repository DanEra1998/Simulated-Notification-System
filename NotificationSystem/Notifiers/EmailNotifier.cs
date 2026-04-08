using System;
using NotificationSystem.Models;

namespace NotificationSystem.Notifiers
{
    public class EmailNotifier
    {
        public void HandleNotification(object sender, NotificationEventArgs e)
        {
            Console.WriteLine($"[EMAIL] To: {e.RecipientName}");
            Console.WriteLine($"[EMAIL] Message: {e.Message}");
            Console.WriteLine($"[EMAIL] Sent at: {e.Timestamp}");
            Console.WriteLine();
        }
    }
}