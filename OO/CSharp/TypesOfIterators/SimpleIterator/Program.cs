using SimpleIterator.Classes;

var words = new WordsList();
words.Add("Supermarket");
words.Add("Shopping");
words.Add("Another random shop");

// words.SetInverseOrder();

foreach (var word in words)
{
    Console.WriteLine(word);
}