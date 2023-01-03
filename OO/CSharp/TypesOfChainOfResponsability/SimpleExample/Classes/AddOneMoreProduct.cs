namespace SimpleExample.Classes;

public class AddOneMoreProduct : ProductModifier
{
    public AddOneMoreProduct(Product product) : base(product)
    {
        
    }

    public override void Handle()
    {
        Product.Quantity += 1;
        base.Handle();
    }
}