using System.Text;

namespace SwitchStatement.Class
{
    public static class SwitchStateMachine
    {
        public static void Start()
        {
            var word = WordGenerator.Generate();
            var state = EWord.Typing;
            var wordHandler = new StringBuilder();

            while (true)
            {
                switch (state)
                {
                    case EWord.Miss:
                        state = EWord.Reset;
                        ResetConsole("You missed the word, try again");
                        wordHandler.Clear();
                        break;
                    case EWord.Right:
                        state = EWord.Reset;
                        ResetConsole("You typed the word correctly", true);
                        wordHandler.Clear();
                        break;
                    case EWord.Typing:
                        wordHandler.Append(Console.ReadKey().KeyChar);

                        if (!word.ToLower().StartsWith(wordHandler.ToString().ToLower()))
                        {
                            state = EWord.Miss;
                        }
                        else if(word.ToLower().Equals(wordHandler.ToString().ToLower()))
                        {
                            state = EWord.Right;
                        }
                        break;
                    case EWord.Reset:
                        word = WordGenerator.Generate();
                        state = EWord.Typing;
                        wordHandler.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private static void ResetConsole(string message, bool win = false)
        {
            Console.ForegroundColor = win ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(message);
            Console.CursorLeft = 0;
            Console.WriteLine("Try again...: ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private enum EWord
        {
            Miss,
            Right,
            Typing,
            Reset
        }
    }
}
