namespace SimpleExample.Classes
{
    public class TaxVisitor : ITaxVisitor
    {
        public double Visit(AlcoholicDrink alcoholicDrink)
        {
            return alcoholicDrink.Price + alcoholicDrink.Price * 0.2;
        }

        public double Visit(JunkFood junkFood)
        {
            return junkFood.Price + junkFood.Price * 0.1;
        }

        public double Visit(Food food)
        {
            return food.Price + food.Price * 0.05;
        }
    }
}
