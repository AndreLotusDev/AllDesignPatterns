namespace TypesOfBridge.Classes.Abstract
{
    public abstract class MessageBase
    {
        protected MessageBase(string title, string body, DateTime whenWasSent)
        {
            Title = title;
            Body = body;
            WhenWasSent = whenWasSent;
        }

        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime WhenWasSent { get; set; }
        public abstract void Send();
    }
}
