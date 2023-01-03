using AbstractFactory.Classes;

var type = "sql";

var factory = new ConnectionPool();
var commandPool = new CommandPool(type);
var connection = factory.GetConnection(type);

connection.AddCommand(commandPool.GenerateCommand("GET ALL PRODUCTS"));
connection.AddCommand(commandPool.GenerateCommand("UPDATE ALL PRODUCTS"));
connection.AddCommand(commandPool.GenerateCommand("GET ALL PRODUCTS"));

Console.WriteLine($"Connection ID {connection.ConnectionId}");
connection.commandsToExecute.ForEach(f => Console.WriteLine(f.BringResult()));