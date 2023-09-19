using System;
using Costoda.CRM.Lib.Models;

namespace Costoda.CRM.Lib.Services
{
    public class MockAuthenticationService
        : IAuthenticationService
    {
        public UserProfile? CurrentUser { get; set; }

        public (bool IsAuthenticated, string ErrorMessage) IsAuthenticated(string username, string password)
        {
            var isAuthenticated = false;
            var errorMessage = string.Empty;

            var users = GetUsers();
            try
            {
                var user = users.First<UserProfile>(x => x.Username == username && x.Password == password);
                if (user != null)
                {
                    isAuthenticated = true;
                    CurrentUser = user;
                }
                else
                {
                    CurrentUser = null;
                }
            } catch (InvalidOperationException)
            {
                errorMessage = "Username or Password is incorrect";
            }
            return (isAuthenticated, errorMessage);
        }

        private UserProfile[] GetUsers()
        {
            return new UserProfile[]
            {
                new UserProfile(Firstname: "Jane", Lastname: "Doe", JobTitle: "Developer", Email:"jane.doe@acme.com", PhoneNumber: "555-555-5555", Department: "Engineering", CellNumber: "555-555-1213", Username: "jane.doe@acme.com", Password: "Password12"),

                 new UserProfile(Firstname: "John", Lastname: "Doe", JobTitle: "Manager", Email:"john.doe@acme.com", PhoneNumber: "555-555-5556", Department: "Engineering", CellNumber: "555-555-1216", Username: "john.doe@acme.com", Password: "Password12"),

            };
        }
    }
}

