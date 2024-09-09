using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class User: Account
    {
        public void EnterUserForm()
        {
            UserForm UserMenu = new UserForm();
            UserMenu.Show();
        }
    }
}
