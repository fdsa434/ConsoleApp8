using ConsoleApp8.question2_interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.classes_ques2
{
    class Authentication_Service : IauthenticationService
    {
        private string username="mohamed";
        private string password="password";
        private string role = "admin";

        public string Username { get; set; }
        public string Password { get ; set ; }
        public string Role { get; set; }


        public bool AuthenticateUser(string username, string password)
        {
            if (username == this.username && password == this.password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Authorize(string username,string role)
        {
            if (username == this.username && role == this.role)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
