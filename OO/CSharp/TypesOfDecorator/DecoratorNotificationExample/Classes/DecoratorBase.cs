namespace DecoratorNotificationExample.Classes
{
    public abstract class DecoratorBase : NotificationBase
    {
        protected NotificationBase _notificationBase;

        public DecoratorBase(NotificationBase notificationBase)
        {
            _notificationBase = notificationBase;
        }

        public void SetComponent(NotificationBase notificationBase)
        {
            _notificationBase = notificationBase;
        }

        public override string Send()
        {
            return _notificationBase.Send();
        }
    }
}
