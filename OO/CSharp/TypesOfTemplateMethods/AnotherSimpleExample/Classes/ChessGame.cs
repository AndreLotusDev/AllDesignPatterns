using static System.Console;

namespace AnotherSimpleExample.Classes
{
    public class ChessGame : BaseGame
    {
        protected override void Start()
        {
            WriteLine($"Starting a game of chess with {numberOfPlayers} players.");

            currentPlayer = FIRST_PLAYER;
        }

        protected override bool HaveWinner { get; set; }

        protected override void TakeTurn()
        {
            SetConsoleForeGroundToRandomColor();

            PrintBigHorizontalLine();
            WriteLine($"The user {GetActualPlayer()} is going to do the move... {GenerateRandomPieceUsed()} ");
            Task.Delay(HALF_SECOND);
            WriteLine($"The user {GetActualPlayer()} has done the move.");

            GeneratePercentWinChance();
            ChangeTheActualPlayer();
            PrintBigHorizontalLine();

            SetConsoleToNormalColor();
        }

        private string GenerateRandomPieceUsed() => new string[] { "King", "Queen", "Bishop", "Knight", "Rook", "Pawn" }[new Random().Next(0, 6)] + " Was used";

        protected override int WinningPlayer { get; set; }

        public ChessGame(int numberOfPlayers) : base(numberOfPlayers)
        {
        }
    }
}
