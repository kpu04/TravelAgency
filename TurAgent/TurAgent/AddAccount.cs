using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class AddAccount: AbstractClassAdd
    {
        DataGridView table;

        public AddAccount(DataGridView table)
        {
            this.table = table;
        }

        public AddAccount()
        {

        }

        public override void Add()
        {
            FillTheTable fillTable = new FillTheTable("accounts.txt", table);
            FillAccountForm fillForm = new FillAccountForm();
            fillForm.HideCh();
            if (fillForm.ShowDialog() == DialogResult.OK)
            {
                table.Rows.Clear();
                fillTable.FillTable();
            }
            fillForm.Dispose();
        }

        public void SaveClient(string login, string password, string role)
        {
            bool check = false;
            string[] accountsData = File.ReadAllLines("accounts.txt");

            for (int i = 0; i < accountsData.Length; i++)
            {
                string[] tour = accountsData[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (tour[0] == login)
                {
                    check = true;
                }
            }

            if (check != true)
            {
                File.AppendAllText("accounts.txt", $"{login};{password};{role}\n");
            }
            else
            {
                MessageBox.Show("Аккаунт с таким логином уже существует", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
