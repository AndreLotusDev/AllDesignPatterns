using SimpleExample.Classes;

var food = new Food(10);
var junk = new JunkFood(10);
var alcohol = new AlcoholicDrink(10);

var cart = new CartProduct(new TaxVisitor());
cart.AddProduct(food);
cart.AddProduct(junk);
cart.AddProduct(alcohol);

cart.VisitProducts();
cart.CalcProductPriceWithoutTax();
