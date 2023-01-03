using System.Reactive.Subjects;

namespace RxDemos.ImplementingObservable.Broker.Classes;

public class GameEventBroker : IObservable<GameEvent>
{
    private readonly Subject<GameEvent> _subscriptions = new Subject<GameEvent>();
    public IDisposable Subscribe(IObserver<GameEvent> observer)
    {
        return _subscriptions.Subscribe(observer);
    }
    
    public void Publish(GameEvent gameEvent) 
    {
        _subscriptions.OnNext(gameEvent);  
    }
}

public class GameEvent
{
    public string PlayerName { get; set; }
    public string To { get; set; }
}

public class PlayerHit : GameEvent
{
    public int Damage { get; set; }
}

public class PlayerSpecialHit : GameEvent
{
    public int Damage { get; set; }
    public ETypeDamage TypeDamage { get; set; }
}

public enum ETypeDamage
{
    COMBO, 
    ULT
}

public class PlayerHeals : GameEvent
{
    public int HealthPoints { get; set;}
}

public class PlayerDie : GameEvent
{
    
}