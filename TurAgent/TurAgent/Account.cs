using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    public class Account
    {
        private string login;
        private string password;
        private string role;

        public Account()
        {
            login = null;
            password = null;
            role = "0";
        }

        public Account(string login, string password, string role)
        {
            this.login = login;
            this.password = password;
            this.role = role;
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
