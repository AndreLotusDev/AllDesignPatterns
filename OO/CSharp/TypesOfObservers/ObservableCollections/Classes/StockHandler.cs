using System.ComponentModel;

namespace ObservableCollections.Classes;

public class StockHandler
{
    public static void Handle(object sender, ListChangedEventArgs args)
    {
        var stocks = sender as BindingList<Stock>;

        if (args.ListChangedType == ListChangedType.ItemAdded)
        {
            var newItem = stocks[args.NewIndex];

            var lastItemOfSameType = stocks.LastOrDefault(l =>
                l.EStockType == newItem.EStockType && newItem.StockName != l.StockName);
            var isThereSameTypeButDifferentStock = lastItemOfSameType != null && lastItemOfSameType != newItem &&
                                                   lastItemOfSameType.StockName != newItem.StockName;
            if (isThereSameTypeButDifferentStock)
            {
                var isCheaper = lastItemOfSameType.StockPrice > newItem.StockPrice;
                var isMoreExpensive = lastItemOfSameType.StockPrice < newItem.StockPrice;

                var priceDifference = Math.Abs(lastItemOfSameType.StockPrice - newItem.StockPrice);

                if (isCheaper)
                    Console.WriteLine($"The new item is cheaper than the older one in {priceDifference}");

                if (isMoreExpensive)
                    Console.WriteLine($"The new item is more expensive than the older one in {priceDifference}");
            }

            var sameStockName = stocks.LastOrDefault(l => l.StockName == newItem.StockName && newItem != l);
            if (sameStockName != null)
            {
                var isCheaper = sameStockName.StockPrice > newItem.StockPrice;
                var isMoreExpensive = sameStockName.StockPrice < newItem.StockPrice;

                var priceDifference = Math.Abs(sameStockName.StockPrice - newItem.StockPrice);

                if (isCheaper)
                    Console.WriteLine(
                        $"There is already a stock with the name {newItem.StockName} and the new price is" +
                        $" cheaper, the difference is {priceDifference}");

                if (isMoreExpensive)
                    Console.WriteLine(
                        $"There is already a stock with the name {newItem.StockName} and the new price is" +
                        $" more expensive, the difference is {priceDifference}");
            }
        }
    }
}