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
    public partial class TravelList : Form
    {
        public TravelList()
        {
            InitializeComponent();
            FillTheTable fillTable = new FillTheTable("travellist.txt", PersonalTravelList);
            fillTable.FillTable();
            SortingComboBox.SelectedIndex = 0;
        }

        private void AddRow_Click(object sender, EventArgs e)
        {
            AddClientToJournal addClientTo = new AddClientToJournal(PersonalTravelList);
            addClientTo.Add();
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            DeleteRow rowDelete = new DeleteRow("travellist.txt", PersonalTravelList);
            rowDelete.Delete();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

            ChangeClientJournal changeClientJournal = new ChangeClientJournal(PersonalTravelList);
            changeClientJournal.ChangeClientRowStart();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            IComparer Comp = new SortingForString(InvSortCheckBox, SortingComboBox.SelectedIndex);
            PersonalTravelList.Sort(Comp);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            Search search = new Search("travellist.txt", PersonalTravelList, SearchTextBox.Text);
            search.Searching();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            PersonalTravelList.Rows.Clear();
            FillTheTable fillTable = new FillTheTable("travellist.txt", PersonalTravelList);
            fillTable.FillTable();
        }
    }
}
