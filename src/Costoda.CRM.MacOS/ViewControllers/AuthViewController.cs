
using Costoda.CRM.Lib.Services;

namespace Costoda.CRM.MacOS
{
	public partial class AuthViewController : NSViewController
	{
        private IAuthenticationService? _authenticationService;

		public AuthViewController (IntPtr handle) : base (handle)
		{

        }
        public override void ViewWillAppear()
        {
            base.ViewWillAppear();

            //set default values
            lblErrorMessage.Hidden = true;

            //setup events for text change to hide/show error message

            if (tfUsername != null)
            {
                tfUsername.Changed += TextFieldValueChanged;
            }

            var appDelegate = NSApplication.SharedApplication.Delegate as AppDelegate;
     
            if (appDelegate?.ServiceProvider is IServiceProvider serviceProvider)
            {
                _authenticationService = serviceProvider.GetService(typeof(IAuthenticationService)) as IAuthenticationService;
            }
        }

        public override void ViewWillDisappear()
        {
            base.ViewWillDisappear();

            if (tfUsername != null)
            {
                tfUsername.Changed -= TextFieldValueChanged;
            }

        }

        partial void Login_Clicked(NSObject sender)
        {
            var username = tfUsername.StringValue.Trim();
            var password = tfPassword.StringValue.Trim();

            if (_authenticationService is not null)
            {
                var isAuthenticated = _authenticationService.IsAuthenticated(username, password);
                if (!isAuthenticated.IsAuthenticated)
                {
                    lblErrorMessage.Hidden = false;
                    lblErrorMessage.StringValue = isAuthenticated.ErrorMessage;

                    //Console.WriteLine(isAuthenticated.ErrorMessage);
                }
                else
                {
                    var appDelegate = NSApplication.SharedApplication.Delegate as AppDelegate;
                    if (appDelegate != null)
                    {
                        appDelegate.ShowMainWindowController();
                    }
                    
                }
         
            }
        }

        private void TextFieldValueChanged(object? sender, EventArgs e)
        {
            lblErrorMessage.Hidden = true;
            lblErrorMessage.StringValue = string.Empty;
        }
    }
}
