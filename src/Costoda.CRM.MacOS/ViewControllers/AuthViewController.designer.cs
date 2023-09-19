// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Costoda.CRM.MacOS
{
	[Register ("AuthViewController")]
	partial class AuthViewController
	{
		[Outlet]
		AppKit.NSTextField lblErrorMessage { get; set; }

		[Outlet]
		AppKit.NSTextField tfPassword { get; set; }

		[Outlet]
		AppKit.NSTextField tfUsername { get; set; }

		[Outlet]
		AppKit.NSView vwBackground { get; set; }

		[Action ("Login_Clicked:")]
		partial void Login_Clicked (Foundation.NSObject sender);

		[Action ("Logo_Clicked:")]
		partial void Logo_Clicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblErrorMessage != null) {
				lblErrorMessage.Dispose ();
				lblErrorMessage = null;
			}

			if (tfPassword != null) {
				tfPassword.Dispose ();
				tfPassword = null;
			}

			if (tfUsername != null) {
				tfUsername.Dispose ();
				tfUsername = null;
			}

			if (vwBackground != null) {
				vwBackground.Dispose ();
				vwBackground = null;
			}
		}
	}
}
