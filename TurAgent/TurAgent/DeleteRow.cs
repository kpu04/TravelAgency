using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TurAgent
{

    internal class DeleteRow : FillTheTable
    {
        private int index;
        public DeleteRow(string path, DataGridView table) : base(path, table)
        {
            this.Path = path;
            this.Table = table;
        }

        public void Delete()
        {
            try
            {
                string[] data = File.ReadAllLines(Path);

                index = Table.CurrentRow.Index;
                Table.Rows.RemoveAt(index);
                FileStream reWrite = new FileStream(Path, FileMode.Truncate);
                reWrite.Close();

                for (int i = 0; i < data.Length; i++)
                {
                    string[] tour = data[i].Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < Table.Rows.Count - 1; j++)
                    {
                        if (tour[0] == Table[0, j].Value.ToString())
                        {
                            File.AppendAllText(Path, $"{data[i]}\n");
                        }
                    }
                }
                Table.Rows.Clear();
                FillTable();
            }
            catch
            {
                MessageBox.Show("Нельзя удалить пустую строку", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
