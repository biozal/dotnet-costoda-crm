using System;
namespace Costoda.CRM.Lib.Models
{
	public record UserProfile(
		string Firstname,
		string Lastname,
		string JobTitle,
		string Email,
		string Department,
		string PhoneNumber,
		string CellNumber,
		string Username,
		string Password)
	{
	}
}

