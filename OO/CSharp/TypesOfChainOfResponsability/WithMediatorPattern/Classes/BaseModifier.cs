using System.Reflection.Metadata;

namespace WithMediatorPattern.Classes;

public abstract class BaseModifier : IDisposable
{
    protected GameController gc;
    protected Soldier soldier;
    
    public BaseModifier(GameController gameController ,Soldier soldier)
    {
        gc = gameController;
        this.soldier = soldier;
        gc.queries += Handle;
    }
    public abstract void Handle(object sender, QuerySoldier q);

    public void Dispose()
    {
        gc.queries -= Handle;
    }
}