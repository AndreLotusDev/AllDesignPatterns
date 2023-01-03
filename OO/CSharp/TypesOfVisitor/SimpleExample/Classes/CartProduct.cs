namespace SimpleExample.Classes
{
    public class CartProduct
    {
        public ITaxVisitor TaxVisitor { get; set; }
        public List<ProductBase> Products { get; set; }

        public CartProduct(ITaxVisitor taxVisitor)
        {
            TaxVisitor = taxVisitor;
            Products = new();
        }

        public void AddProduct(ProductBase product)
        {
            Products.Add(product);
        }

        public void VisitProducts()
        {
            int totalPrice = 0;

            foreach (var product in Products)
            {
                totalPrice += (int)product.Visit(taxVisitor: TaxVisitor);
            }

            Console.WriteLine("The total price is: " + totalPrice);
        }

        public void CalcProductPriceWithoutTax()
        {
            int totalPrice = 0;

            foreach (var product in Products)
            {
                totalPrice += product.Price;
            }

            Console.WriteLine("The total price without tax is: " + totalPrice);
        }
    }
}
