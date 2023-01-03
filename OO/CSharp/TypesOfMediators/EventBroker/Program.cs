using Autofac;
using RxDemos.ImplementingObservable.Broker.Classes;

var cb = new ContainerBuilder();
cb.RegisterType<GameEventBroker>().SingleInstance();
cb.RegisterType<GameController>();
cb.Register((c, p) => 
  new Player(c.Resolve<GameEventBroker>(), p.Named<string>("playerName")));

using (var c = cb.Build())
{
  var gc = c.Resolve<GameController>(); 
  var player1 = c.Resolve<Player>(new NamedParameter("playerName", "John"));
  var player2 = c.Resolve<Player>(new NamedParameter("playerName", "Chris"));
        
  player1.DoAHit(10, player2.PlayerName);
  player1.DoASpecialHit(player2.PlayerName, ETypeDamage.COMBO , 85);
  player2.Heals(30);
  player2.DoAHit(10, player1.PlayerName);
  player1.DoASpecialHit(player2.PlayerName, ETypeDamage.ULT, 100);
}