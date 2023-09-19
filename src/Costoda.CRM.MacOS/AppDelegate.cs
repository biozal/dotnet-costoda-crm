namespace Costoda.CRM.MacOS;
using Costoda.CRM.Lib.Services;

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
		Console.WriteLine("Show Main View here");	
    }
}

