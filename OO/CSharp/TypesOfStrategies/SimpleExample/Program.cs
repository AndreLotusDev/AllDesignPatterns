using Autofac;
using SimpleExample.Classes;

var containerBuilder = new ContainerBuilder();

var isChristmas = DateTime.Now.Date == new DateTime(DateTime.Now.Year, 12, 25).Date;
if (isChristmas)
{
    containerBuilder.RegisterType<ChritsmasDiscountStrategy>().As<IDiscountStrategy>();
}
else
{
    containerBuilder.RegisterType<NormalDiscountStrategy>().As<IDiscountStrategy>();
}

var container = containerBuilder.Build();

var product = new Product(1, "Nike", "Shoe", 1_000, "Shoes");
var product2 = new Product(2, "Puma", "Shoe", 2_000, "Shoes");

var shoppingCart = new ShoppingCart(container.Resolve<IDiscountStrategy>());
shoppingCart.Add(product);
shoppingCart.Add(product2);

Console.WriteLine("The total price is: " + shoppingCart.CalculateTotalPrice());
