using Autofac;
using MediatR;
using MediaTRExample.Classes;

var builder = new ContainerBuilder();
builder.RegisterType<Mediator>()
    .As<IMediator>()
    .InstancePerLifetimeScope();
    
builder.Register<ServiceFactory>(context =>
{
    var c = context.Resolve<IComponentContext>();
    return t => c.Resolve(t);
});

builder.RegisterAssemblyTypes(typeof(Program).Assembly)
    .AsImplementedInterfaces();
    
var container = builder.Build();
var mediator = container.Resolve<IMediator>(); 

var response = await mediator.Send(new PongCommand() {TimeToSleep = 2});
Console.WriteLine("Program finalizing...");