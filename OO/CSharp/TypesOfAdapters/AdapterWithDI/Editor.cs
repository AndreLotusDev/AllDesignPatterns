namespace TypesOfAdapters;

public class Editor
{
    private readonly IEnumerable<Button> _buttons;

    public Editor(IEnumerable<Button> buttons)
    {
        _buttons = buttons;
    }

    public void ClickInAllButtons()
    {
        foreach (var button in _buttons)
        {
            button.Click();
        }
    }
}