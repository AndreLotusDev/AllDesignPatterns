using TypesOfBridge.Classes.Abstract;

namespace TypesOfBridge.Classes
{
    public class IOSMessage : MessageBase
    {
        public IOSMessage(string title, string body, DateTime whenWasSent) : 
            base(title, body, whenWasSent)
        {
            if (!title.ToLower().Contains("ios"))
            {
                throw new Exception("The title doesn't contain the platform");
            }
        }

        public override void Send()
        {
            Console.WriteLine($"Send by IOS with the title: {Title}");
            Console.WriteLine($"Message: {Body}");
        }
    }
}
