namespace Costoda.CRM.MacOS;

public class MainWindowDelegate 
    : NSWindowDelegate
{
    private readonly WeakReference<MainWindowController> _windowController;
    
    public MainWindowDelegate(MainWindowController windowController)
    {
        _windowController = new WeakReference<MainWindowController>(windowController);
    }
    public override void WillClose(NSNotification notification)
    {
        var didGetController = _windowController.TryGetTarget(out var windowController);
        if (didGetController && windowController != null)
        {
            windowController.WillClose();
        }
    }
}