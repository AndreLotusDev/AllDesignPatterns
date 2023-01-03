namespace ModernSimpleExample.Classes
{
    public class Cellphone
    {
        public EStatusCellphone ActualStatusCellphone { get; set; }
    }

    public enum EStatusCellphone
    {
        Offline,
        Online,
        Talking
    }

    public enum ETriggerCellphone
    {
        TurnOf,
        TurnOn,
        ReceiveCall,
        ShutDownCall
    }
}
