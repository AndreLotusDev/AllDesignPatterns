namespace SimpleExample.Classes;

public class Product
{
    public int Price { get; set; }
    public int Quantity {get; set; }
    public string Name { get; set; }
    public bool IsFree { get; set; }

    public Product(int price, int quantity, string name)
    {
        Price = price;
        Quantity = quantity;
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public int GetPrice()
    {
        if (IsFree)
        {
            return 0;
        }
        
        return Price * Quantity;
    }
}