using TypesOfBridge.Classes.Abstract;

namespace TypesOfBridge.Classes
{
    public class WebPlatform : PlatformSenderBase
    {
        public WebPlatform(MessageBase messageBase) : base(messageBase)
        {
        }

        public override void DeliveryMessage()
        {
            Console.WriteLine("Send by web");
            _messageBase.Send();
        }
    }
}
