using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    public partial class AuthorisationForm : Form
    {
        public AuthorisationForm()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Authorization auth = new Authorization(LoginTextBox.Text, PasswordTextBox.Text);
            auth.EnterAccount(this);
        }

        private void CreateAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrateAccount registrateAccount = new RegistrateAccount();
            if (registrateAccount.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Аккаунт создан успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            registrateAccount.Dispose();
        }
    }
}