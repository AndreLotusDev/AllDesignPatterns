namespace BidirectionalFields.Classes;

public static class RegisterInteractionBetween
{
    public static BidirectionalBinding Register(Stock stock, Window window)
    {
        return new BidirectionalBinding(
            stock, 
            () => stock.StockValue,
            window,
            () => window.StockValue);
    }
}