namespace DecoratorNotificationExample.Classes
{
    public class FacebookNotificationDecorator : DecoratorBase
    {
        public FacebookNotificationDecorator(NotificationBase notificationBase) : base(notificationBase)
        {

        }
        public override string Send()
        {
            Console.WriteLine("Starting sending to FB...");
            Task.Delay(1000);
            AddPlatform(SendBy.Facebook);
            return "Sending to facebook..." + base.Send();
        }
    }
}
