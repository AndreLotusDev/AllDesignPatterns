namespace WithMediatorPattern.Classes;

public class QuerySoldier
{
    public QuerySoldier(string soldierName, int value, QueryType type)
    {
        SoldierName = soldierName;
        Value = value;
        Type = type;
    }

    public string SoldierName { get; set; }
    public int Value { get; set; }

    public enum QueryType
    {
        SPEED,
        ATTACK
    }

    public QueryType Type { get; set; }
}