using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurAgent
{
    public partial class UserTourForm : Form
    {
        public UserTourForm()
        {
            InitializeComponent();
            FillTheTable fillTable = new FillTheTable("tourlist.txt", TourDataGrid);
            fillTable.FillTable();
            SortingComboBox.SelectedIndex = 0;
        }

        private void SortByCode_Click(object sender, EventArgs e)
        {
            IComparer Comp = new SortingForString(InversSortCheckBox, SortingComboBox.SelectedIndex);
            TourDataGrid.Sort(Comp);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search("tourlist.txt", TourDataGrid, SearchTextBox.Text);
            search.Searching();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TourDataGrid.Rows.Clear();
            FillTheTable fillTable = new FillTheTable("tourlist.txt", TourDataGrid);
            fillTable.FillTable();
        }

        private void Order_Click(object sender, EventArgs e)
        {
            FillJournalForm fillJournalForm = new FillJournalForm();
            fillJournalForm.HideCh();
            if (fillJournalForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Путёвка забронирована. Чтобы подтвердить бронь, свяжитесь с компанией в течении 7-и дней. Для внесения изменений обратитесь в службу поддержки", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            fillJournalForm.Dispose();
        }



    }
}
