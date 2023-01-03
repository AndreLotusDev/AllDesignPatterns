using TypesOfBridge.Classes.Abstract;

namespace TypesOfBridge.Classes
{
    public class WhatsappPlatform : PlatformSenderBase
    {
        public WhatsappPlatform(MessageBase messageBase) : base(messageBase)
        {
        }

        public override void DeliveryMessage()
        {
            Console.WriteLine("Send by wpp");
            _messageBase.Send();
        }
    }
}
