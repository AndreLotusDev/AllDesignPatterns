namespace ObservableCollections.Classes;

public class Stock
{
    public string StockName { get; set; }
    public decimal StockPrice { get; set;}
    public EStockType EStockType { get; set; }
    
    public Stock(string stockName, decimal stockPrice, EStockType type)
    {
        StockName = stockName;
        StockPrice = stockPrice;
        EStockType = type;
    }
}

public enum EStockType
{
    Resource,
    Technology,
    Financial
}