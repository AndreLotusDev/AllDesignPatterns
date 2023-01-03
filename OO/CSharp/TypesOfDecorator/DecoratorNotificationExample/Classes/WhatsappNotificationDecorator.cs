namespace DecoratorNotificationExample.Classes
{
    public class WhatsappNotificationDecorator : DecoratorBase
    {
        public WhatsappNotificationDecorator(NotificationBase notificationBase) : base(notificationBase)
        {
        }

        public override string Send()
        {
            Console.WriteLine("Starting sending to wpp...");
            Task.Delay(1000);
            AddPlatform(SendBy.Whatsapp);
            return "Sending to wpp..." + base.Send();
        }
    }
}
