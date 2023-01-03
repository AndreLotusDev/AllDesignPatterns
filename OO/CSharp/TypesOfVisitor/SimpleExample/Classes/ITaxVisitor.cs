namespace SimpleExample.Classes
{
    public interface ITaxVisitor
    {
        double Visit(AlcoholicDrink alcoholicDrink);
        double Visit(JunkFood junkFood);
        double Visit(Food food);
    }
}
