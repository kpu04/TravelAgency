using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace TurAgent
{
    internal class SortingForString : IComparer
    {
        CheckBox checkSortRB;
        int index;

        public SortingForString(CheckBox rb, int index)
        {
            checkSortRB = rb;
            this.index = index;
        }

        public int Compare(Object a, Object b)
        {
            DataGridViewRow Row1 = (DataGridViewRow)a;
            DataGridViewRow Row2 = (DataGridViewRow)b;

            if (checkSortRB.Checked == false)
            {
                if (int.TryParse(Row1.Cells[index].Value.ToString(), out int value1) &&
                    int.TryParse(Row2.Cells[index].Value.ToString(), out int value2))
                {
                    return value1.CompareTo(value2);
                }
                else
                {
                    return string.Compare(Row1.Cells[index].Value.ToString(), Row2.Cells[index].Value.ToString());
                }
            }
            else
            {
                if (int.TryParse(Row1.Cells[index].Value.ToString(), out int value1) &&
                    int.TryParse(Row2.Cells[index].Value.ToString(), out int value2))
                {
                    return value2.CompareTo(value1);
                }
                else
                {
                    return string.Compare(Row2.Cells[index].Value.ToString(), Row1.Cells[index].Value.ToString());
                }
            }
        }
    }
}