using System.Reactive.Linq;

namespace RxDemos.ImplementingObservable.Broker.Classes;

public class Actor
{
    protected GameEventBroker broker;

    public Actor(GameEventBroker broker)
    {
        this.broker = broker ?? throw new ArgumentNullException(paramName: nameof(broker));
    }
}