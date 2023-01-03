namespace SimpleExample.Classes;

public class ShoppingCart
{
    private readonly IDiscountStrategy _discountStrategy;
    public List<Product> Products { get; set; }
    
    public ShoppingCart(IDiscountStrategy strategy)
    {
        Products = new List<Product>();
        _discountStrategy = strategy;
    }
    
    public void Add(Product product)
    {
        Products.Add(product);
    }
    
    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (var product in Products)
        {
            totalPrice += product.Price;
        }
        
        var priceWithDiscount = _discountStrategy.GetDiscount(totalPrice);
        return priceWithDiscount;
    }
}