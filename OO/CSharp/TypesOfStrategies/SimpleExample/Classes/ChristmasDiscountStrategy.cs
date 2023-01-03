namespace SimpleExample.Classes;

public class ChritsmasDiscountStrategy : IDiscountStrategy
{
    private const int TEN_PERCENT = 10;
    
    public double GetDiscount(double price)
    {
        if (price >= 1_000)
        {
            return price - (TEN_PERCENT * (price / 100));
        }

        return price;
    }
}