using System.ComponentModel;

namespace ObservableCollections.Classes;

public class StockMarket
{
    public BindingList<Stock> Stocks = new BindingList<Stock>();
    
    public StockMarket()
    {
        
    }
    
    public void AddStock(Stock stock)
    {
        Stocks.Add(stock);
    }
}