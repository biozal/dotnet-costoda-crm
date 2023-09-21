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
	[Register ("CompanyCollectionViewItem")]
	partial class CompanyCollectionViewItem
	{
		[Outlet]
		AppKit.NSTextField lblCityState { get; set; }

		[Outlet]
		AppKit.NSTextField lblCompany { get; set; }

		[Outlet]
		AppKit.NSTextField lblCountry { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (lblCompany != null) {
				lblCompany.Dispose ();
				lblCompany = null;
			}

			if (lblCityState != null) {
				lblCityState.Dispose ();
				lblCityState = null;
			}

			if (lblCountry != null) {
				lblCountry.Dispose ();
				lblCountry = null;
			}

		}
	}
}
