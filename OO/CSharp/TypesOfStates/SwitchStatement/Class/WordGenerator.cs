namespace SwitchStatement.Class
{
    public static class WordGenerator
    {
        public static string Generate()
        {
            var random = new Random();
            var word = string.Empty;
            var length = random.Next(1, 10);
            for (var i = 0; i < length; i++)
            {
                word += (char)random.Next(97, 122);
            }
            Console.WriteLine("The word to type is : " + word);
            return word;
        }
    }
}
