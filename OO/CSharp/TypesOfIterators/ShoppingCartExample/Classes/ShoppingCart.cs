using System.Collections;

namespace ShoppingCartExample.Classes;

public class ShoppingCart : EnumerableBase
{
    public List<Product> Products { get; set; } = new();
    private Func<Product, object> OrderingConfig { get; set; }

    public void SetOrder(Func<Product, object> key)
    {
        OrderingConfig = key;
    }

    public List<Product> GetItems()
    {
        if (OrderingConfig == null)
        {
            return Products;
        }
        
        return Products.OrderBy(OrderingConfig).ToList();
    }

    public override IEnumerator GetEnumerator()
    {
        return new ShoppingCartIterator(this);
    }
}

public class Product
{
    public Product(string name, double value)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Value = value;
    }

    public string Name { get; set; }
    public double Value { get; set; }

    public override string ToString()
    {
        return $"Name: {Name} | Value {Value}";
    }
}