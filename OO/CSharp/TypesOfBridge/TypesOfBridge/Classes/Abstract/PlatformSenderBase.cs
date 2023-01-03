namespace TypesOfBridge.Classes.Abstract
{
    public abstract class PlatformSenderBase
    {
        protected readonly MessageBase _messageBase;

        protected PlatformSenderBase(MessageBase messageBase)
        {
            _messageBase = messageBase;
        }

        public abstract void DeliveryMessage();
    }
}
