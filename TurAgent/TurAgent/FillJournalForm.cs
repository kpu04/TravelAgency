using System;
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
    public partial class FillJournalForm : Form
    {
        ClientsJournal client;
        DataGridView table;

        public FillJournalForm()
        {
            InitializeComponent();
        }
        public FillJournalForm(ClientsJournal client, DataGridView table)
        {
            InitializeComponent();
            SurnameTextBox.Text = client.Clients.Surname;
            NameTextBox.Text = client.Clients.Name;
            PatronymicTextBox.Text = client.Clients.Patronymic;
            PassporNumTextBox.Text = client.Clients.PassportNumber;
            TourCodeTextBox.Text = client.TourCode;
            this.client = client;
            this.table = table;
        }

        public FillJournalForm(DataGridView table)
        {
            this.table = table;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SurnameTextBox.Text != "" && NameTextBox.Text != "" && PatronymicTextBox.Text != "" && PassporNumTextBox.Text != "" && TourCodeTextBox.Text != "")
            {
                if (client == null)
                {
                    AddClientToJournal addClientToJournal = new AddClientToJournal();
                    addClientToJournal.SaveClient(SurnameTextBox.Text, NameTextBox.Text, PatronymicTextBox.Text, PassporNumTextBox.Text, TourCodeTextBox.Text);
                }
            }
            else
            {
                MessageBox.Show("Не должно быть пустых ячеек", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                if (table.Rows[i].Cells[3].Value == client.Clients.PassportNumber && table.Rows[i].Cells[4].Value == client.TourCode)
                {
                    table[0, i].Value = SurnameTextBox.Text;
                    table[1, i].Value = NameTextBox.Text;
                    table[2, i].Value = PatronymicTextBox.Text;
                    table[3, i].Value = PassporNumTextBox.Text;
                    table[4, i].Value = TourCodeTextBox.Text;
                }
            }

            ChangeClientJournal change = new ChangeClientJournal();
            change.ChangeClientRowEnd(client, SurnameTextBox.Text, NameTextBox.Text, PatronymicTextBox.Text, PassporNumTextBox.Text, TourCodeTextBox.Text);
        }

        public void HideCh()
        {
            if (ChangeButton != null)
            {
                ChangeButton.Visible = false;
            }
        }

    }
}
