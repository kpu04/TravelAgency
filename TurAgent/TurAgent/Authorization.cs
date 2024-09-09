using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class Authorization
    {
        Account account = new Account();

        public Authorization(string login, string password)
        {
            account.Login = login;
            account.Password = password;
        }

        public void EnterAccount(AuthorisationForm form)
        {
            string role = "0";
            bool isRightAccount = DoAuthorization(account.Login, account.Password, ref role);
            if (isRightAccount == true)
            {
                if (role == "1")
                {
                    Admin admin = new Admin();
                    admin.EnterAdminForm();
                    form.Hide();
                }
                else
                {
                    User user = new User();
                    user.EnterUserForm();
                    form.Hide();
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool DoAuthorization(string enteredLogin, string enteredPassword, ref string userrole)
        {
            bool isRightAccount = false;
            string[] account = File.ReadAllLines("accounts.txt");
            for (int i = 0; i < account.Length; i++)
            {
                string[] userData = account[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (string.Compare(userData[0], enteredLogin) == 0 && string.Compare(userData[1], enteredPassword) == 0)
                {
                    userrole = userData[2];
                    return isRightAccount = true;
                }
            }
            return isRightAccount;
        }
    }
}
