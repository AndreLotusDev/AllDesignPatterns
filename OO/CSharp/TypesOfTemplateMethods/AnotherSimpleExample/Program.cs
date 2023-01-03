using AnotherSimpleExample.Classes;

var checkerGame = new CheckerGame(2);
checkerGame.Run(true);

Console.WriteLine("Thanks for playing!");
Console.WriteLine("Cleaning the history");
Thread.Sleep(3000);
Console.Clear();

var chessGame = new ChessGame(2);
chessGame.Run(false);