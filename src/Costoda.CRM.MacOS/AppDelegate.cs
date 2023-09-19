namespace Costoda.CRM.MacOS;
using Lib.Services;

using Microsoft.Extensions.DependencyInjection;

[Register ("AppDelegate")]
public class AppDelegate : NSApplicationDelegate {

    public IServiceProvider ServiceProvider { get; private set; }

    public AppDelegate()
    {
        var services = new ServiceCollection();

        // Insert code here to initialize your application
        services.AddSingleton<IAuthenticationService, MockAuthenticationService>();

        ServiceProvider = services.BuildServiceProvider();
    }

	public override void WillTerminate (NSNotification notification)
	{
		// Insert code here to tear down your application
	}

    public void ShowMainWindowController()
    {
		var storyboard = NSStoryboard.FromName("Main", null);
		var mainWindowController = (NSWindowController)storyboard.InstantiateControllerWithIdentifier("MainWindowController");
		
	    //close current authentication window 
		var currentActiveWindow = NSApplication.SharedApplication.KeyWindow;
	    currentActiveWindow.Close();
	    
	    //bring up new window
	    var startingSize = new CGSize(1024, 768);
		mainWindowController.Window.MinSize = startingSize;
		mainWindowController.Window.Center();
		mainWindowController.Window.MakeKeyAndOrderFront(null);

    }
}

