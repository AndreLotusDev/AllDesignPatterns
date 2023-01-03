using static System.Console;

namespace FunctionalApproach.Classes
{
    public class CheckerFunctional : HelperGameBase
    {
        public void Execute()
        {
            GameTemplateBase.Run(
                Start,
                TakeTurn,
                () => HaveWinner,
                () => WinningPlayer
            );
        }


        protected void Start()
        {
            WriteLine($"Starting a game of checker with {numberOfPlayers} players.");

            currentPlayer = FIRST_PLAYER;
        }
        protected void TakeTurn()
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
    }
}
