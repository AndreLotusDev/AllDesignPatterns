using WeakEvent;

namespace ProperWayToConnectEventHandlers.Classes;

public class Button : IDisposable
{
    public event EventHandler Clicked;

    public void Fire()
    {
        Clicked?.Invoke(this, EventArgs.Empty);
    }

    public void Dispose()
    {
        Clicked = null;
    }
}