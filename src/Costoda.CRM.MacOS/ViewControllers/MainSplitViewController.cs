using ObjCRuntime;

namespace Costoda.CRM.MacOS.ViewControllers;

public partial class MainSplitViewController : NSSplitViewController {


	protected MainSplitViewController(IntPtr handle) : base(handle)
    {

	}

	public override void ViewDidLoad ()
	{
		base.ViewDidLoad ();
	}
}

