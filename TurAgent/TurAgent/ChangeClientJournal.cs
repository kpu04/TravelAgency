using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurAgent
{
    internal class ChangeClientJournal
    {
        DataGridView table;

        public ChangeClientJournal()
        {

        }

        public ChangeClientJournal(DataGridView table)
        {
            this.table = table;
        }

        public void ChangeClientRowStart()
        {
            FillTheTable fillTable = new FillTheTable("travellist.txt", table);
            int index = table.CurrentRow.Index;
            if (table[0, index].Value == null)
            {
                MessageBox.Show("Нельзя изменить пустую строку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClientsJournal clientsJournal = new ClientsJournal(table[0, index].Value.ToString(), table[1, index].Value.ToString(), table[2, index].Value.ToString(), table[3, index].Value.ToString(), table[4, index].Value.ToString());
                FillJournalForm fillJournalForm = new FillJournalForm(clientsJournal, table);
                if (fillJournalForm.ShowDialog() == DialogResult.OK)
                {
                    table.Rows.Clear();
                    fillTable.FillTable();
                }
                fillJournalForm.Dispose();
            }
        }

        public void ChangeClientRowEnd(ClientsJournal client, string surname, string name, string patronymic, string passportNum, string tourCode)
        {
            string[] data = File.ReadAllLines("travellist.txt");
            FileStream reWrite = new FileStream("travellist.txt", FileMode.Truncate);
            reWrite.Close();

            for (int i = 0; i < data.Length; i++)
            {
                string[] client1 = data[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (client1[3] != client.Clients.PassportNumber && client1[4] != client.TourCode)
                {
                    File.AppendAllText("travellist.txt", data[i] + "\n");
                }
                else
                {
                    File.AppendAllText("travellist.txt", $"{surname};{name};{patronymic};{passportNum};{tourCode}\n");
                }
            }
        }
    }
}
