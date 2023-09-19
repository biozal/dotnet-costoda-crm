using System;
using Costoda.CRM.Lib.Models;

namespace Costoda.CRM.Lib.Services
{
	public interface IAuthenticationService
	{
		public UserProfile? CurrentUser { get; set; }

		public (bool IsAuthenticated, string ErrorMessage) IsAuthenticated(string username, string password);
	}
}

