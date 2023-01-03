namespace SimpleExample.Classes;

public class PercentageDiscount : ProductModifier
{
    public PercentageDiscount(Product product) : base(product)
    {
    }

    public override void Handle()
    {
        Product.Price = Product.Price - (Product.Price * (1 / 10));
        base.Handle();
    }
}