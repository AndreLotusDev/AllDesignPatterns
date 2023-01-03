using WeakEvent;
using static System.Console;

namespace ProperWayToConnectEventHandlers.Classes;

public class Window : IDisposable
{
    private readonly Button _button;
    public Window(Button button)
    {
        _button = button; 
        _button.Clicked += ButtonOnClicked;
    }

    private void ButtonOnClicked(object sender, EventArgs eventArgs)
    {
        WriteLine("Button clicked (Window handler)");
    }

    public void Execute()
    {
        WriteLine("Executing");
    }

    public void Dispose()
    {
        _button.Clicked -= ButtonOnClicked;
        WriteLine("Window finalized");
    }

    ~Window()
    {
        WriteLine("Disposed");
    }
}