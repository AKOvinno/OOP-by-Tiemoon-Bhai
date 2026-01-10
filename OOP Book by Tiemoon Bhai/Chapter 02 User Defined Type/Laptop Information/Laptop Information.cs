using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptop_Information
{
    public partial class LaptopInfoUI : Form
    {
        LaptopInfoClass aLaptop = new LaptopInfoClass();
        public LaptopInfoUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveAndClearButton_Click(object sender, EventArgs e)
        {
            aLaptop.BrandName = BrandNameTextBox.Text;
            aLaptop.RamSize = Convert.ToInt32(RamSizeTextBox.Text);
            aLaptop.ProcessorCore = Convert.ToInt32(ProcessorCoreTextBox.Text);
            BrandNameTextBox.Text = "";
            RamSizeTextBox.Text = "";
            ProcessorCoreTextBox.Text = "";
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            BrandNameTextBox.Text = aLaptop.BrandName;
            RamSizeTextBox.Text = aLaptop.RamSize.ToString();
            ProcessorCoreTextBox.Text = aLaptop.ProcessorCore.ToString();
            string info = aLaptop.sAppropriateForProgrammer();
            isAppropriateForProgrammerTextBox.Text = info;
        }

        private void isAppropriateForProgrammerTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
