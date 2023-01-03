using System.Reactive.Linq;

namespace RxDemos.ImplementingObservable.Broker.Classes;

public class Player : Actor
{
    private IDisposable sub;
    public string PlayerName { get; set; }
    public bool IsAlive { get; set; } = true;
    
    public int MAX_HEALTH { get; } = 100;
    public int ActualHealth { get; set; } = 100;

    public Player(GameEventBroker broker, string playerName) : base(broker)
    {
        PlayerName = playerName;

        broker.OfType<PlayerHit>()
            .Where(p => p.PlayerName.ToLower().Contains(PlayerName.ToLower()))
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Did a hit to another player");
            });
        
        broker.OfType<PlayerHit>()
            .Where(p => p.To.ToLower().Contains(PlayerName.ToLower()))
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Take damage from another player");
            });
        
        broker.OfType<PlayerSpecialHit>()
            .Where(p => p.PlayerName.ToLower().Contains(PlayerName.ToLower()))
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Did a special hit to another player");
                
                CheckIfIsGoingToDie(s.Damage, s.PlayerName);
            });
        
        broker.OfType<PlayerSpecialHit>()
            .Where(p => p.To.ToLower().Contains(PlayerName.ToLower()))
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Take special hit from another player");
                
                CheckIfIsGoingToDie(s.Damage, s.PlayerName);
            });
        
        broker.OfType<PlayerHeals>()
            .Where(p => p.PlayerName.ToLower().Contains(PlayerName.ToLower()))
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Player healed himself");
            });
        
        broker.OfType<PlayerDie>()
            .Where(p => p.PlayerName.ToLower().Contains(PlayerName.ToLower()))
            .Subscribe(s =>
            {
                Console.WriteLine(
                    $"Player died");
            });
    }

    //To implement a posteriori
    public void DoAHit(int damage, string name)
    {
        broker.Publish(new PlayerHit() { Damage = damage, To = name, PlayerName = this.PlayerName });
    }

    public void DoASpecialHit(string name, ETypeDamage typeDamage, int damage)
    {
        broker.Publish(new PlayerSpecialHit()
            { Damage = damage, To = name, PlayerName = this.PlayerName, TypeDamage = typeDamage }); 
    }

    public void Heals(int healthPoints)
    {
        if (ActualHealth + healthPoints < MAX_HEALTH)
        {
            ActualHealth += healthPoints;
            broker.Publish(new PlayerHeals() { HealthPoints = healthPoints, PlayerName = this.PlayerName });
        }
        else
        {
            var missingToMax = MAX_HEALTH - healthPoints;
            ActualHealth += missingToMax;
            broker.Publish(new PlayerHeals() { HealthPoints = missingToMax, PlayerName = this.PlayerName });
        }
    }

    public void CheckIfIsGoingToDie(int damage, string name)
    {
        if (ActualHealth - damage <= 0)
        {
            Console.WriteLine("Char died");
            IsAlive = false;
            broker.Publish(new PlayerDie() { To = name, PlayerName = this.PlayerName });
        }
    }
}