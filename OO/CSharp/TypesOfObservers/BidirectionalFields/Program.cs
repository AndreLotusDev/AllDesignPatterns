using BidirectionalFields.Classes;

var stock = new Stock("FB", 2800.ToString());
var window = new Window(stock);

using (var binding = new BidirectionalBinding(stock, () => stock.StockValue,
           window, () => window.StockValue))
{

    stock.StockValue = 2700.ToString();
    window.StockValue = 3800.ToString();
    // stock.StockValue = 3900;
    
    Console.WriteLine(stock.ToString());
}

