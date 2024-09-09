using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TurAgent
{
    public partial class TourForm : Form
    {

        public TourForm()
        {
            InitializeComponent();
            FillTheTable fillTable = new FillTheTable("tourlist.txt", TourDataGrid);
            fillTable.FillTable();
            SortingComboBox.SelectedIndex = 0;
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            AddTour newTour = new AddTour(TourDataGrid);
            newTour.Add();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            DeleteRow rowDelete = new DeleteRow("tourlist.txt", TourDataGrid);
            rowDelete.Delete();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            ChangeTour tour = new ChangeTour(TourDataGrid);
            tour.ChangeTourRowStart();
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
    }
}
