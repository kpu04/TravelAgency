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
    public partial class FillNewRowTourForm : Form
    {
        DataGridView table;
        Tour tour;
        public FillNewRowTourForm()
        {
            InitializeComponent();
        }

        public FillNewRowTourForm(Tour tour, DataGridView table)
        {
            InitializeComponent();
            CodeTextBox.Text = tour.Code;
            CountryTextBox.Text = tour.Country;
            CityTextBox.Text = tour.City;
            HotelTextBox.Text = tour.Hotel;
            TransportTextBox.Text = tour.Transportation;
            PriceTextBox.Text = tour.Price;
            DaysTextBox.Text = tour.Days;
            this.table = table;
            this.tour = tour;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (CodeTextBox.Text != null && CodeTextBox.Text != "" && CountryTextBox.Text != null && CountryTextBox.Text != "" && CityTextBox.Text != null && CityTextBox.Text != "" && HotelTextBox.Text != null && HotelTextBox.Text != "" && TransportTextBox.Text != null && TransportTextBox.Text != "" && PriceTextBox.Text != null && PriceTextBox.Text != "" && DaysTextBox.Text != null && DaysTextBox.Text != "")
            {
                AddTour addTour = new AddTour();
                addTour.SaveTour(CodeTextBox.Text, CountryTextBox.Text, CityTextBox.Text, HotelTextBox.Text, TransportTextBox.Text, PriceTextBox.Text, DaysTextBox.Text);
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
                if (table.Rows[i].Cells[0].Value == tour.Code)
                {
                    table[0, i].Value = CodeTextBox.Text;
                    table[1, i].Value = CountryTextBox.Text;
                    table[2, i].Value = CityTextBox.Text;
                    table[3, i].Value = HotelTextBox.Text;
                    table[4, i].Value = TransportTextBox.Text;
                    table[5, i].Value = PriceTextBox.Text;
                    table[6, i].Value = DaysTextBox.Text;
                }
            }

            ChangeTour change = new ChangeTour();
            change.ChangeTourRowEnd(tour, CodeTextBox.Text, CountryTextBox.Text, CityTextBox.Text, HotelTextBox.Text, TransportTextBox.Text, PriceTextBox.Text, DaysTextBox.Text);
            this.Close();
        }

        public void HideCh()
        {
            ChangeButton.Visible = false;
        }
    }
}
