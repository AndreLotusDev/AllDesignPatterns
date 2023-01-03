namespace SimpleExample.Classes
{
    public class JunkFood : ProductBase
    {
        public JunkFood(int price) : base("Junk Food", price) { }
        public override double Visit(ITaxVisitor taxVisitor)
        {
            return taxVisitor.Visit(this);
        }
    }
}
