using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.question2_interface
{
    interface IauthenticationService
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool AuthenticateUser(string username,string password);
        public bool Authorize(string username,string role);


    }
}
