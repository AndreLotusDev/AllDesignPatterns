using static System.Console;

namespace AnotherSimpleExample.Classes
{
    public abstract class BaseGame
    {
        protected const int FIRST_PLAYER = 0;
        protected const int SECOND_PLAYER = 1;

        protected const int ONE_SECOND = 1000;
        protected const int HALF_SECOND = 500;

        protected const int PERCENTAGE_OF_WIN = 1;

        public void Run(bool clear = true)
        {
            Start();
            while (!HaveWinner)
                TakeTurn();
            WriteLine($"Player {WinningPlayer + 1} wins.");
            Thread.Sleep(1500);
            if(clear)
                Clear();
        }

        protected abstract void Start();
        protected abstract bool HaveWinner { get; set; }
        protected abstract void TakeTurn();
        protected abstract int WinningPlayer { get; set; }

        protected int currentPlayer;
        protected readonly int numberOfPlayers;

        public BaseGame(int numberOfPlayers)
        {
            this.numberOfPlayers = numberOfPlayers;
        }

        public string GetActualPlayer()
        {
            if (currentPlayer == FIRST_PLAYER)
            {
                return nameof(FIRST_PLAYER);
            }
            else
            {
                return nameof(SECOND_PLAYER);
            }
        }

        public void ChangeTheActualPlayer()
        {
            if (currentPlayer == FIRST_PLAYER)
            {
                currentPlayer = SECOND_PLAYER;
            }
            else
            {
                currentPlayer = FIRST_PLAYER;
            }
        }

        protected void GeneratePercentWinChance()
        {
            var random = new Random();
            var randomValue = random.Next(0, 100);

            if (randomValue <= PERCENTAGE_OF_WIN)
            {
                HaveWinner = true;
                WinningPlayer = currentPlayer;

                WriteLine($"The user {GetActualPlayer()} has won the game.");
                currentPlayer = SECOND_PLAYER;
            }
        }

        protected void SetConsoleForeGroundToRandomColor()
        {
            ForegroundColor = (ConsoleColor)new Random().Next(1, 15);
        }

        protected void SetConsoleToNormalColor() => ForegroundColor = ConsoleColor.White;

        protected void PrintBigHorizontalLine()
        {
            WriteLine("--------------------------------------------------");
        }
    }
}
