using ShoppingCartExample.Classes;

var nike = new Product("Nike", 280);
var adidas = new Product("Adidas", 180);
var puma = new Product("Puma", 120);

ShoppingCart sc = new ShoppingCart();
sc.Products.Add(nike);
sc.Products.Add(adidas);
sc.Products.Add(puma);

sc.SetOrder(p => p.Name); //Order by name

foreach (var product in sc)
{
    Console.WriteLine(product);
}