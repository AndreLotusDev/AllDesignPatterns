using ProperWayToConnectEventHandlers.Classes;
using static System.Console;

(var btn, var windowRef) = Execute();

FireGC();

WriteLine($"Is window alive after GC? {windowRef.IsAlive}");
btn.Fire();
btn = null;
Window winTest = (Window)windowRef.Target;
winTest?.Execute();
// WriteLine("This is not working");


static void FireGC()
{
    WriteLine("================================================");
    WriteLine("Starting GC");
    GC.Collect();
    GC.WaitForPendingFinalizers();
    WriteLine("GC is done!");
    WriteLine("================================================");
}

static (Button, WeakReference) Execute()
{
    var btn = new Button();
    WeakReference windowRef;
    using (var window = new Window(btn))
    {
        windowRef = new WeakReference(window);
        btn.Fire();
    }
    
    return (btn, windowRef);
}