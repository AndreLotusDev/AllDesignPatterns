namespace WithMediatorPattern.Classes;

public class IncreaseSpeedModifier : BaseModifier
{
    public IncreaseSpeedModifier(GameController gameController, Soldier soldier) : base(gameController, soldier)
    {
       
    }

    public override void Handle(object sender, QuerySoldier q)
    {
        if (q.SoldierName == soldier.Name && q.Type == QuerySoldier.QueryType.SPEED)
        {
            q.Value *= 2;
        }
    }
}