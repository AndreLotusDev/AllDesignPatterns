namespace DecoratorNotificationExample.Classes
{
    public class GmailNotificationDecorator : DecoratorBase
    {
        public GmailNotificationDecorator(NotificationBase notificationBase) : base(notificationBase)
        {
        }

        public override string Send()
        {
            Console.WriteLine("Starting sending to gmail...");
            Task.Delay(1000);
            AddPlatform(SendBy.Gmail);
            return "Sending to gmail..." + base.Send();
        }
    }
}
