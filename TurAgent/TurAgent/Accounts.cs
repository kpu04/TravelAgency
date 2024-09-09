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
    public partial class Accounts : Form
    {
        public Accounts()
        {
            InitializeComponent();
            FillTheTable fillTable = new FillTheTable("accounts.txt", AccountsGridView);
            fillTable.FillTable();
            SortComboBox.SelectedIndex = 0;
        }

        private void AddAccount_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount(AccountsGridView);
            addAccount.Add();
        }

        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteRow rowDelete = new DeleteRow("accounts.txt", AccountsGridView);
            rowDelete.Delete();
        }

        private void ChangeAccount_Click(object sender, EventArgs e)
        {
            ChangeAccount change = new ChangeAccount(AccountsGridView);
            change.ChangeAccountRowStart();
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            IComparer Comp = new SortingForString(InverseCheckBox, SortComboBox.SelectedIndex);
            AccountsGridView.Sort(Comp);
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search search = new Search("accounts.txt", AccountsGridView, SearchTextBox.Text);
            search.Searching();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            AccountsGridView.Rows.Clear();
            FillTheTable fillTable = new FillTheTable("accounts.txt", AccountsGridView);
            fillTable.FillTable();
        }

        private void InverseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AccountsGridView.Rows.Clear();
            FillTheTable filltable = new FillTheTable("accounts.txt", AccountsGridView);
            filltable.FillTable();
        }
    }
}
