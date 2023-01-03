namespace SimpleExample.Classes
{
    public abstract class ProductBase
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductBase(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public abstract double Visit(ITaxVisitor taxVisitor);
    }
}
