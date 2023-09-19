using System;
namespace Costoda.CRM.MacOS.Controls
{
	public static class NSWindowExtension
	{
		public static void CenterWindow(this NSWindow value)
		{
            CGRect screenRect = NSScreen.MainScreen.Frame;

            // Calculate the centered frame
            nfloat windowX = (screenRect.Width - value.Frame.Width) / 2;
            nfloat windowY = (screenRect.Height - value.Frame.Height) / 2;
            CGRect centeredRect = new CGRect(windowX, windowY, value.Frame.Width, value.Frame.Height);

            // Set the window's frame
            value.SetFrame(centeredRect, true);
        }
	}
}

