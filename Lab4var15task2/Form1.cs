using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System;

namespace Lab4var15task2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void displayButton_Click_1(object sender, EventArgs e)
        {
            string position = (string)jobListBox.SelectedItem;
            double experience = (double)experienceNumericUpDown.Value;
            string salary = (string)salaryComboBox.SelectedItem;

            if (position != null && salary != null)
            {
                string result = $"Посада: {position}\nДосвід: {experience} років\nЗарплата: {salary}";
                resultRichTextBox.Text = result;
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть посаду та зарплату перед відображенням.");
            }
        }
    }
}
