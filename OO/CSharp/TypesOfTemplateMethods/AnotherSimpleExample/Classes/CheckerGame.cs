using static System.Console;

namespace AnotherSimpleExample.Classes
{
    public class CheckerGame : BaseGame
    {
        public CheckerGame(int numberOfPlayers) : base(numberOfPlayers)
        {
        }

        protected override void Start()
        {
            WriteLine($"Starting a game of checker with {numberOfPlayers} players.");

            currentPlayer = FIRST_PLAYER;
        }

        protected override bool HaveWinner { get; set; }

        protected override void TakeTurn()
        {
            SetConsoleForeGroundToRandomColor();

            PrintBigHorizontalLine();
            WriteLine($"The user {GetActualPlayer()} is going to do the move... ");
            Task.Delay(HALF_SECOND);
            WriteLine($"The user {GetActualPlayer()} has done the move.");

            GeneratePercentWinChance();
            ChangeTheActualPlayer();
            PrintBigHorizontalLine();

            SetConsoleToNormalColor();
        }

        protected override int WinningPlayer { get; set; }
    }
}
