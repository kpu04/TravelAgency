using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class Admin: Account
    {
        public void EnterAdminForm()
        {
            AdminMenuForm Menu = new AdminMenuForm();
            Menu.Show();
        }
    }
}
