using SimpleExample.Classes;

var foodProduct = new Product(10, 2, "Avocado");

var avocadoWithDiscout = new PercentageDiscount(foodProduct);

avocadoWithDiscout.Add(new AddOneMoreProduct(foodProduct));
avocadoWithDiscout.Handle();

Console.WriteLine(foodProduct.GetPrice());
