using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurAgent
{
    public partial class RegistrateAccount : Form
    {
        public RegistrateAccount()
        {
            InitializeComponent();
        }

        private void RegistrateButton_Click(object sender, EventArgs e)
        {
            bool check = false;
            string[] accountsData = File.ReadAllLines("accounts.txt");

            for (int i = 0; i < accountsData.Length; i++)
            {
                string[] tour = accountsData[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (tour[0] == LoginTextBox.Text)
                {
                    check = true;
                }
            }

            if (check != true)
            {
                File.AppendAllText("accounts.txt", $"{LoginTextBox.Text};{PasswordTextBox.Text};0\n");
            }
            else
            {
                MessageBox.Show("Аккаунт с таким логином уже существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
