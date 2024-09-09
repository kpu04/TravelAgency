using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class ChangeAccount
    {
        DataGridView table;

        public ChangeAccount(DataGridView table)
        {
            this.table = table;
        }

        public ChangeAccount()
        {

        }

        public void ChangeAccountRowStart()
        {
            FillTheTable fillTable = new FillTheTable("accounts.txt", table);
            int index = table.CurrentRow.Index;
            if (table[0, index].Value == null)
            {
                MessageBox.Show("Нельзя изменить пустую строку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Account account = new Account(table[0, index].Value.ToString(), table[1, index].Value.ToString(), table[2, index].Value.ToString());
                FillAccountForm fn = new FillAccountForm(account, table);
                if (fn.ShowDialog() == DialogResult.OK)
                {
                    table.Rows.Clear();
                    fillTable.FillTable();
                }
                fn.Dispose();
            }
        }

        public void ChangeAccountRowEnd(Account account, string login, string password, string role)
        {
            string[] data = File.ReadAllLines("accounts.txt");
            FileStream reWrite = new FileStream("accounts.txt", FileMode.Truncate);
            reWrite.Close();

            for (int i = 0; i < data.Length; i++)
            {
                string[] tour1 = data[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (tour1[0] != account.Login)
                {
                    File.AppendAllText("accounts.txt", data[i] + "\n");
                }
                else
                {
                    File.AppendAllText("accounts.txt", $"{login};{password};{role}\n");
                }
            }
        }
    }
}
