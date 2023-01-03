using Autofac;
using SimpleAdapter.Classes;
using SimpleAdapter.Interfaces;

var email = new Email() { Address = "andrsoares953@yahoo.com" };

var container = new ContainerBuilder();
container.RegisterType<Validator>().As<IValidator>();
var b = container.Build();
var validator = b.Resolve<IValidator>();

var isValidEmail = validator.IsAValidEmail(email.Address);
var isValidDateOne = validator.IsAValidDate("10/10/2022");
var isValidDateSecond = validator.IsAValidDate("10/2022/101");

Console.WriteLine(isValidEmail);
Console.WriteLine(isValidDateOne);
Console.WriteLine(isValidDateSecond);