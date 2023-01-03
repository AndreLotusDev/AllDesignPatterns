namespace ClassicSimpleExample.Classes
{
    public class DefenseState : SoldierSwitchBase
    {
        public override void SetToDefenseMode(Soldier soldier)
        {
            if (soldier.Status == EStatus.DEFENSE)
            {
                base.SetToDefenseMode(soldier);
            }
            else
            {
                Console.WriteLine("Changed to defense mode");
                soldier.Status = EStatus.DEFENSE;
            }
        }
    }
}
