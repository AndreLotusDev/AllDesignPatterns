using SimpleExample.Classes;

StartGame();



void StartGame()
{
    Console.WriteLine("Press C to earn points");
    
    WaitForOtherKey();

    ClickController.Instance().AddGameOver();

    Console.WriteLine("Game over, press R to reload the game");
    
    var keyReturnedToRestart = Console.ReadKey();
    if (keyReturnedToRestart.Key == ConsoleKey.R)
    {
        StartGame();
    }
    else
    {
        Console.WriteLine("Game finished, thanks for playing");
        Console.WriteLine($"Pontuation: {ClickController.Instance().Pontuation}");
        Console.WriteLine($"Game Overs: {ClickController.Instance().GameOvers}");

        Console.WriteLine("=====================================");
        Console.WriteLine("Thanks for playing");
        Thread.Sleep(5000);
    }
}

void WaitForOtherKey()
{
    var keyReturned = Console.ReadKey();

    while (keyReturned.Key == ConsoleKey.C)
    {
        ClickController.Instance().AddPontuation();
        
        keyReturned = Console.ReadKey();
    }
}