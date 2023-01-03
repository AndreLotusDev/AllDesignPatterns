namespace SimpleExample.Classes;

public class NormalDiscountStrategy : IDiscountStrategy
{
    private const int FIVE_PERCENT = 5;
    public double GetDiscount(double price)
    {
        if (price >= 1_000)
        {
            return price - (FIVE_PERCENT * (price / 100));
        }
        
        return price;
    }
}