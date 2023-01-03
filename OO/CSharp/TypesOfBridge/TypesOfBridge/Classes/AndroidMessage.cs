using TypesOfBridge.Classes.Abstract;

namespace TypesOfBridge.Classes
{
    public class AndroidMessage : MessageBase
    {
        public AndroidMessage(string title, string body, DateTime whenWasSent) :
            base(title, body, whenWasSent)
        {
            if (!title.ToLower().Contains("android"))
            {
                throw new Exception("The title doesn't contain the platform");
            }
        }
        public override void Send()
        {
            Console.WriteLine($"Send by android with the title: {Title}");
            Console.WriteLine($"Message: {Body}");
        }
    }
}
