namespace SimpleExample.Classes
{
    public class AlcoholicDrink : ProductBase
    {
        public AlcoholicDrink(int price) : base("Alcoholic Drink", price) { }
        public override double Visit(ITaxVisitor taxVisitor)
        {
            return taxVisitor.Visit(this);
        }
    }
}
