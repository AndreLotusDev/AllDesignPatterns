namespace WithMediatorPattern.Classes;

public class FortifyAttackModifier : BaseModifier
{
    public FortifyAttackModifier(GameController gameController, Soldier soldier) : base(gameController, soldier)
    {
    }

    public override void Handle(object sender, QuerySoldier q)
    {
        if(q.SoldierName == soldier.Name && q.Type == QuerySoldier.QueryType.ATTACK)
        {
            q.Value *= 2;
        }
    }
}