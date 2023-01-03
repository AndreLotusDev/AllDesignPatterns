namespace ClassicSimpleExample.Classes
{
    public class AttackState : SoldierSwitchBase
    {
        public AttackState()
        {
            Console.WriteLine("Start changing the mode!");
        }

        public override void SetToAttackMode(Soldier soldier)
        {
            if (soldier.Status == EStatus.ATACK)
            {
                base.SetToAttackMode(soldier);
            }
            else
            {
                Console.WriteLine("Changed to attack mode");
                soldier.Status = EStatus.ATACK;
            }
        }
    }
}
