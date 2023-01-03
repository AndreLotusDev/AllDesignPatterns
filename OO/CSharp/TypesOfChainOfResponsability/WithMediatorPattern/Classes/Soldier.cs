namespace WithMediatorPattern.Classes;

public class Soldier
{
    private GameController _gc;
    public Soldier(GameController gc,string name, int moveSpeed, int damage)
    {
        Name = name;
        _gc = gc;
        this.moveSpeed = moveSpeed;
        this.damage = damage;
    }

    public string Name { get; set; }

    public int MoveSpeed
    {
        get
        {
            var q = new QuerySoldier(Name, moveSpeed, QuerySoldier.QueryType.SPEED);
            _gc.ExecuteQueries(this ,q);
            return q.Value;
        }
    }
    private int moveSpeed;

    public int Damage
    {
        get
        {
            var q = new QuerySoldier(Name, damage, QuerySoldier.QueryType.ATTACK);
            _gc.ExecuteQueries(this ,q);
            return q.Value;
        }
    }

    private int damage;

    public override string ToString()
    {
        return $"Name {Name} | Damage {Damage} | Move Speed {MoveSpeed}" ;
    }
}