namespace TypesOfAdapters;

public class EditCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Im editing a file");
    }
}