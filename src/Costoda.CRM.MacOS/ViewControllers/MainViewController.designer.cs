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
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		AppKit.NSCollectionView colViewMain { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (colViewMain != null) {
				colViewMain.Dispose ();
				colViewMain = null;
			}

		}
	}
}
