using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class FillTheTable
    {
        private int index;
        private string path;
        DataGridView table;
        public FillTheTable(string path, DataGridView table)
        {
            this.path = path;
            this.table = table;
        }

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        public DataGridView Table
        {
            get { return table; }
            set { table = value; }
        }

        public void FillTable()
        {
            string[] tourData = File.ReadAllLines(path);
            for (int i = 0; i < tourData.Length; i++)
            {
                string[] tour = tourData[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                table.Rows.Add(tour);
            }
        }
    }
}
