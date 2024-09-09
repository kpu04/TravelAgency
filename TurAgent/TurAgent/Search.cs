using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TurAgent
{
    internal class Search
    {
        string path;
        DataGridView table;
        string pattern;

        public Search(string path, DataGridView table, string pattern)
        {
            this.path = path;
            this.table = table;
            this.pattern = pattern;
        }

        public void Searching()
        {
            string[] data = File.ReadAllLines(path);
            table.Rows.Clear();
            for (int i = 0; i < data.Length; i++)
            {
                if (Regex.IsMatch(data[i], pattern) == true)
                {
                    string[] dataRow = data[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    table.Rows.Add(dataRow);
                }
            }
        }
    }
}
