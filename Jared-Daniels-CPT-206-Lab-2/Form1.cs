using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jared_Daniels_CPT_206_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);
        }

        // Sort the cities by population in ascending order
        private void btnSortAsc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortAsc(this.cityDBDataSet.City);
        }

        // Sort the cities by population in descending order
        private void btnSortDesc_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortDesc(this.cityDBDataSet.City);
        }

        // Sort the cities by name
        private void btnSortName_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.SortCity(this.cityDBDataSet.City);
        }

        // Display the total population of all cities
        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Population of all Cities is: " + this.cityTableAdapter.TotalPopulation(), "Total Population");
        }

        // Display the average population of all cities
        private void btnAverage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Average Population of all Cities is: " + this.cityTableAdapter.AvgPopulation(), "Average Population");
        }

        // Display the highest population of all cities
        private void btnHighest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Highest Population of all Cities is: " + this.cityTableAdapter.HighestPopulation(), "Highest Population");
        }

        // Display the lowest population of all cities
        private void btnLowest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lowest Population of all Cities is: " + this.cityTableAdapter.LowestPopulation(), "Lowest Population");
        }

        // Close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
