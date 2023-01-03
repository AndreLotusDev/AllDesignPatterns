namespace SimpleExample.Classes;

public class ProductModifier
{
    protected Product Product;
    protected ProductModifier Next;

    public ProductModifier(Product product)
    {
        Product = product;
    }

    public void Add(ProductModifier pm)
    {
        if (Next != null) Next.Add(pm);
        else Next = pm;
    }

    public virtual void Handle() => Next?.Handle();
}