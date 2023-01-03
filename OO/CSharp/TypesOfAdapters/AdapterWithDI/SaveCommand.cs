namespace TypesOfAdapters;

public class SaveCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Im saving a file");
    }
}