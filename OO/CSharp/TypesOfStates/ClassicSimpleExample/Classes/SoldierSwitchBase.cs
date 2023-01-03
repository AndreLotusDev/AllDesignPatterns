namespace ClassicSimpleExample.Classes
{
    public abstract class SoldierSwitchBase
    {
        public virtual void SetToAttackMode(Soldier soldier)
        {
            Console.WriteLine("You are already in attack mode");
        }

        public virtual void SetToDefenseMode(Soldier soldier)
        {
            Console.WriteLine("You are already in defense mode");
        }
    }
}
