using System;
using NotificationSystem.Services;
using NotificationSystem.Notifiers;

namespace NotificationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create the publisher
            NotificationService service = new NotificationService();

            // create the subscribers
            EmailNotifier emailNotifier = new EmailNotifier();
            SMSNotifier smsNotifier = new SMSNotifier();
            LogNotifier logNotifier = new LogNotifier();

            // subscribe to the event
            service.OnNotificationSent += emailNotifier.HandleNotification;
            service.OnNotificationSent += smsNotifier.HandleNotification;
            service.OnNotificationSent += logNotifier.HandleNotification;

            // fire the event
            service.SendNotification("Jason", "Your mortgage payment is due in 3 days.");
            service.SendNotification("Daniel", "Your account balance is below the minimum threshold.");
        }
    }
}