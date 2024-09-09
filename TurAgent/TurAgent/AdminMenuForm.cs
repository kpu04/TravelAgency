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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
        }

        private void Tours_Click(object sender, EventArgs e)
        {

            TourForm tourf = new TourForm();
            tourf.Show();
        }

        private void WorkJournalButton_Click(object sender, EventArgs e)
        {
            TravelList tl = new TravelList();
            tl.Show();
        }

        private void WorkWithAccountsButton_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.Show();
        }

        private void ComeBack_Click(object sender, EventArgs e)
        {
            AuthorisationForm form = new AuthorisationForm();
            form.Show();
            this.Close();
        }
    }
}
