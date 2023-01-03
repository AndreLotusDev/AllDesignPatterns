namespace DecoratorNotificationExample.Classes
{
    public class NotificationConcrete : NotificationBase
    {
        public override string Send()
        {
            Task.Delay(1000);
            return "... Finished to send to all platforms";
        }
    }
}
