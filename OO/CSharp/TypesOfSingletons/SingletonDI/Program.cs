using Autofac;
using SingletonDI.Classes;

var builder = new ContainerBuilder();

builder.RegisterType<PointController>().SingleInstance();
builder.RegisterType<GameController>().SingleInstance();

var collectionServices = builder.Build();

var gameController = collectionServices.Resolve<GameController>();
gameController.PointController.AddPoints();
gameController.PointController.AddPoints();

Thread.Sleep(1000);

var anotherGameController = collectionServices.Resolve<GameController>();

anotherGameController.PointController.AddPoints();

Console.WriteLine(anotherGameController.PointController.TotalPoints);