using System.Reactive.Linq;

namespace RxDemos.ImplementingObservable.Broker.Classes;

public class GameController : Actor
{
    public GameController(GameEventBroker broker) : base(broker)
    {
        broker.OfType<PlayerHit>()
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Game Controller: Player {s.PlayerName} did a hit to {s.To} with {s.Damage} damage points.");
            });
        
        broker.OfType<PlayerSpecialHit>()
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Game Controller: Player {s.PlayerName} did a special hit {s.TypeDamage.ToString()} to {s.To} with {s.Damage} damage points.");
            });
        
        broker.OfType<PlayerHeals>()
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Game Controller: Player {s.PlayerName} did a heal of {s.HealthPoints}.");
            });
        
        broker.OfType<PlayerDie>()
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Game Controller: Player {s.PlayerName} died to {s.To}.");
            });
    }
}