using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class AddClientToJournal: AbstractClassAdd
    {
        DataGridView table;

        public AddClientToJournal()
        {
        }

        public AddClientToJournal(DataGridView table)
        {
            this.table = table;
        }

        public override void Add()
        {
            FillTheTable fillTable = new FillTheTable("travellist.txt", table);
            FillJournalForm fn = new FillJournalForm();
            fn.HideCh();
            if (fn.ShowDialog() == DialogResult.OK)
            {
                table.Rows.Clear();
                fillTable.FillTable();
            }
            fn.Dispose();
        }

        public void SaveClient(string surname, string name, string patronymic, string passportNum, string tourCode)
        {
            File.AppendAllText("travellist.txt", $"{surname};{name};{patronymic};{passportNum};{tourCode}\n");
        }
    }
}
