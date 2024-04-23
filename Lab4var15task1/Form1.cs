using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4var15task1
{
    public partial class Form1 : Form
    {
        private HashSet<string> cities = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlanTrip_Click_1(object sender, EventArgs e)
        {
            if (comboBoxCities.SelectedIndex != -1)
            {
                string selectedCity = comboBoxCities.SelectedItem.ToString();
                outputTextBox.Text = $"Ви обрали місто: {selectedCity}";
            }
            else
            {
                outputTextBox.Text = "Оберіть місто зі списку!";
            }
        }

        private void buttonAddCity_Click_1(object sender, EventArgs e)
        {
            string newCity = textBoxNewCity.Text.Trim();

            if (!string.IsNullOrEmpty(newCity))
            {
                if (!cities.Contains(newCity))
                {
                    comboBoxCities.Items.Add(newCity);
                    cities.Add(newCity);
                    textBoxNewCity.Clear();
                }
                else
                {
                    MessageBox.Show("Це місто вже існує у списку!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введіть назву міста!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
