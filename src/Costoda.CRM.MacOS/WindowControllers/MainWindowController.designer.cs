// WARNING
//
// This file has been generated automatically by Rider IDE
//   to store outlets and actions made in Xcode.
// If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Costoda.CRM.MacOS
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		AppKit.NSToolbarItem tbItemCampaigns { get; set; }

		[Outlet]
		AppKit.NSToolbarItem tbItemCompanies { get; set; }

		[Outlet]
		AppKit.NSToolbarItem tbItemContacts { get; set; }

		[Outlet]
		AppKit.NSToolbarItem tbItemMyProfile { get; set; }

		[Outlet]
		AppKit.NSToolbar tbMainToolbar { get; set; }

		[Outlet]
		AppKit.NSSearchToolbarItem tbSearchBar { get; set; }

		[Action ("companyClicked:")]
		partial void companyClicked (Foundation.NSObject sender);

		void ReleaseDesignerOutlets ()
		{
			if (tbMainToolbar != null) {
				tbMainToolbar.Dispose ();
				tbMainToolbar = null;
			}

			if (tbItemCompanies != null) {
				tbItemCompanies.Dispose ();
				tbItemCompanies = null;
			}

			if (tbItemContacts != null) {
				tbItemContacts.Dispose ();
				tbItemContacts = null;
			}

			if (tbItemCampaigns != null) {
				tbItemCampaigns.Dispose ();
				tbItemCampaigns = null;
			}

			if (tbItemMyProfile != null) {
				tbItemMyProfile.Dispose ();
				tbItemMyProfile = null;
			}

			if (tbSearchBar != null) {
				tbSearchBar.Dispose ();
				tbSearchBar = null;
			}

		}
	}
}
