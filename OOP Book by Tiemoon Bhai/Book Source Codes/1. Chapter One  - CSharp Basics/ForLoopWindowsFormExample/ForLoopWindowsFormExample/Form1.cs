using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoorLoopWindowsFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showOddNumberButton_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt16(fromTextBox.Text);
            int to = Convert.ToInt16(toTextBox.Text);

            string oddNumberString = "";

            for (int i = from; i <= to; i++)
            {
                if (i%2 != 0)
                {
                    oddNumberString += i + " ";
                }
            }
            MessageBox.Show(oddNumberString, "Odd Number");
        }

        private void showEvenNumberTextBox_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt16(fromTextBox.Text);
            int to = Convert.ToInt16(toTextBox.Text);

            string evenNumberString = "";

            for (int i = from; i <= to; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumberString += i + " ";
                }
            }
            MessageBox.Show(evenNumberString, "Even number");
        }
    }
}
