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
    public partial class FillAccountForm : Form
    {
        DataGridView table;
        Account account;
        public FillAccountForm()
        {
            InitializeComponent();
        }

        public FillAccountForm(Account account, DataGridView table)
        {
            InitializeComponent();
            LogimTextBox.Text = account.Login;
            PasswordTextBox.Text = account.Password;
            RoleTextBox.Text = account.Role;
            this.table = table;
            this.account = account;
        }


        private void AddAccount_Click(object sender, EventArgs e)
        {
            if (LogimTextBox.Text != "" && PasswordTextBox.Text != "" && RoleTextBox.Text != "")
            {
                AddAccount addAccount = new AddAccount();
                addAccount.SaveClient(LogimTextBox.Text, PasswordTextBox.Text, RoleTextBox.Text);
            }
            else
            {
                MessageBox.Show("Не должно быть пустых ячеек", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeAccount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                if (table.Rows[i].Cells[0].Value == account.Login)
                {
                    table[0, i].Value = LogimTextBox.Text;
                    table[1, i].Value = PasswordTextBox.Text;
                    table[2, i].Value = RoleTextBox.Text;
                }
            }

            ChangeAccount change = new ChangeAccount();
            change.ChangeAccountRowEnd(account, LogimTextBox.Text, PasswordTextBox.Text, RoleTextBox.Text);
        }

        public void HideCh()
        {
            ChangeAccount.Visible = false;
        }
    }
}
