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
    internal class ChangeTour
    {
        DataGridView TourDataGrid;

        public ChangeTour(DataGridView table)
        {
            TourDataGrid = table;
        }

        public ChangeTour()
        {

        }

        public void ChangeTourRowStart()
        {
            FillTheTable fillTable = new FillTheTable("tourlist.txt", TourDataGrid);
            int index = TourDataGrid.CurrentRow.Index;
            if (TourDataGrid[0, index].Value == null)
            {
                MessageBox.Show("Нельзя изменить пустую строку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Tour tour = new Tour(TourDataGrid[0, index].Value.ToString(), TourDataGrid[1, index].Value.ToString(), TourDataGrid[2, index].Value.ToString(), TourDataGrid[3, index].Value.ToString(), TourDataGrid[4, index].Value.ToString(), TourDataGrid[5, index].Value.ToString(), TourDataGrid[6, index].Value.ToString());
                FillNewRowTourForm fn = new FillNewRowTourForm(tour, TourDataGrid);
                if (fn.ShowDialog() == DialogResult.OK)
                {
                    TourDataGrid.Rows.Clear();
                    fillTable.FillTable();
                }
                fn.Dispose();
            }
        }

        public void ChangeTourRowEnd(Tour tour, string code, string country, string city, string hotel, string transport, string price, string days)
        {
            string[] data = File.ReadAllLines("tourlist.txt");
            FileStream reWrite = new FileStream("tourlist.txt", FileMode.Truncate);
            reWrite.Close();

            for (int i = 0; i < data.Length; i++)
            {
                string[] tour1 = data[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (tour1[0] != tour.Code)
                {
                    File.AppendAllText("tourlist.txt", data[i] + "\n");
                }
                else
                {
                    File.AppendAllText("tourlist.txt", $"{code};{country};{city};{hotel};{transport};{price};{days}\n");
                }
            }
        }
    }
}
