using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project.BusinessLogic_layer
{
    class Capturer
    {
        private string username;
        private string password;

        public Capturer(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        

        public override string ToString()
        {
            return "Username: " + username + "| Password: " + password;
        }

    }
}
