using System.ComponentModel;
using ObservableCollections.Classes;

var stockFb = new Stock( "FB" , 100.00m, EStockType.Technology);
var stockGoog = new Stock( "GOOG" , 1000.00m, EStockType.Technology);
var stockMsft = new Stock( "MSFT" , 100.00m, EStockType.Technology);
var stockFarmer = new Stock( "FARMER" , 100.00m, EStockType.Resource);
var stockOil = new Stock( "OIL" , 100.00m, EStockType.Resource);
var stockFinance = new Stock( "FINANCE" , 100.00m, EStockType.Financial);
var stockGoog2 = new Stock( "GOOG" , 10000.00m, EStockType.Technology);

var stockMarket = new StockMarket();
stockMarket.Stocks.ListChanged += StockHandler.Handle;

stockMarket.Stocks.Add(stockFb);
stockMarket.Stocks.Add(stockGoog);
stockMarket.Stocks.Add(stockMsft);
stockMarket.Stocks.Add(stockFarmer);
stockMarket.Stocks.Add(stockOil);
stockMarket.Stocks.Add(stockFinance);
stockMarket.Stocks.Add(stockGoog2);