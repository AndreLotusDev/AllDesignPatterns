namespace SimpleExample.Classes
{
    public class Food : ProductBase
    {
        public Food(int price) : base("Food" , price) {}
        public override double Visit(ITaxVisitor taxVisitor)
        {
            return taxVisitor.Visit(this);
        }
    }
}
