namespace TypesOfAdapters;

public class Button
{
    private readonly ICommand _command;
    private readonly string _buttonName;
    
    public Button(ICommand command, string buttonName)
    {
        _command = command;
        _buttonName = buttonName;
    }

    public void Click()
    {
        Console.WriteLine($"Button {_buttonName} clicked!");
        _command.Execute();
    }
}