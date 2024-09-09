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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void TourInfo_Click(object sender, EventArgs e)
        {
            UserTourForm userTourForm = new UserTourForm();
            userTourForm.Show();
        }

        private void ComeBack_Click(object sender, EventArgs e)
        {
            AuthorisationForm form = new AuthorisationForm();
            form.Show();
            this.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вас приветствует техническая поддержка туристического агенства PnP travel!\nДля связи с нами обратитесь по номерам: +375447263432, +375295956342.");
        }
    }
}
