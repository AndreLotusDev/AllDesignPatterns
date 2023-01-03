namespace ClassicSimpleExample.Classes
{
    public class Soldier
    {
        public EStatus? Status { get; set; }

    }

    public enum EStatus
    {
        ATACK,
        DEFENSE
    }
}
