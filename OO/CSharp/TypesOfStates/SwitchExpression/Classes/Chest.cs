namespace SwitchExpression.Classes
{
    public class Chest
    {
        public Chest()
        {
            Status = EStatus.Lock;
            HaveTheKey = false;
        }
        
        public EStatus Status { get; set; }
        public bool HaveTheKey { get; set; }

        public enum EAction
        {
            Open, Close
        }

        public enum EStatus
        {
            Lock, Unlock
        }
    }
}
