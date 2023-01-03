namespace DecoratorNotificationExample.Classes
{
    public abstract class NotificationBase
    {
        public abstract string Send();
        public List<SendBy> SendByList { get; set; } = new();

        public void AddPlatform(SendBy sendBy)
        {
            SendByList.Add(sendBy);
        }
    }

    public enum SendBy
    {
        Whatsapp,
        Facebook,
        Gmail
    }
}
