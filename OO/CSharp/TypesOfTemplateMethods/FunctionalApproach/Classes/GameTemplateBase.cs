using static System.Console;

namespace FunctionalApproach.Classes
{
    public static class GameTemplateBase
    {
        public static void Run(
        Action start,
        Action takeTurn,
        Func<bool> haveWinner,
        Func<int> winningPlayer, 
        bool clear = false)
        {
            start();
            while (!haveWinner())
                takeTurn();
            WriteLine($"Player {winningPlayer() + 1} wins.");
            Thread.Sleep(1500);
            if (clear)
                Clear();
        }
    }
}
