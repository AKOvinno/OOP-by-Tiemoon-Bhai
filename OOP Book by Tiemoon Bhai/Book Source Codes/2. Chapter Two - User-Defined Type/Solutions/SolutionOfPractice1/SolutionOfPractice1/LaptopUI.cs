using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionOfPractice1
{
    public partial class LaptopUI : Form
    {
        Laptop aLaptop = new Laptop();
        public LaptopUI()
        {
            InitializeComponent();
        }

        private void saveAndClearButton_Click(object sender, EventArgs e)
        {
            aLaptop.brandName = brandNameTextBox.Text;
            aLaptop.ramSizeInGB = Convert.ToInt32(ramSizeTextBox.Text);
            aLaptop.NumberOfCore = Convert.ToInt32(processorCoreNumberTextBox.Text);

            ClearTextBoxes();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            brandNameTextBox.Text = aLaptop.brandName;
            ramSizeTextBox.Text = aLaptop.ramSizeInGB.ToString();
            processorCoreNumberTextBox.Text = aLaptop.NumberOfCore.ToString();
        }

        private void ClearTextBoxes()
        {
            brandNameTextBox.Text = "";
            ramSizeTextBox.Text = "";
            processorCoreNumberTextBox.Text = "";
        }
    }
}
