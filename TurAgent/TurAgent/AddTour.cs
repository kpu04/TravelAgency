using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurAgent
{
    internal class AddTour: AbstractClassAdd
    {
        DataGridView table;

        public AddTour(DataGridView table)
        {
            this.table = table;
        }
        public AddTour() 
        { 
        }

        public override void Add()
        {
            FillTheTable fillTable = new FillTheTable("tourlist.txt", table);
            FillNewRowTourForm fn = new FillNewRowTourForm();
            fn.HideCh();
            if (fn.ShowDialog() == DialogResult.OK)
            {
                table.Rows.Clear();
                fillTable.FillTable();
            }
            fn.Dispose();
        }

        public void SaveTour(string code, string country, string city, string hotel, string transport, string price, string days)
        {
            bool check = false;
            string[] tourData = File.ReadAllLines("tourlist.txt");

            for (int i = 0; i < tourData.Length; i++)
            {
                string[] tour = tourData[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (tour[0] == code)
                {
                    check = true;
                }
            }

            if (check == false)
            {
                File.AppendAllText("tourlist.txt", $"{code};{country};{city};{hotel};{transport};{price};{days}\n");
            }
            else
            {
                MessageBox.Show("Тур с таким кодом уже существует! Поменяйте код!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
    }
}
