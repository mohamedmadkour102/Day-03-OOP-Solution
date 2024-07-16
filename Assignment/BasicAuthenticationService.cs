using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class BasicAuthenticationService : IAuthenticationService
    {
         string Username;
         string Password;
         string Role;

        public BasicAuthenticationService(string username, string password, string role)
        {
            Username = username;
            Password = password;
            Role = role;
        }

        public bool AuthenticateUser(string username, string password)
        {
            
            if (username == Username && password == Password)
                return true;
            else
                return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            
            if (username == Username && role == Role)
                return true;
            else
                return false;
        }
    }
}
