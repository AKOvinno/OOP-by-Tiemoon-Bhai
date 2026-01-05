using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odd_EvenWithinLimit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowOddNum_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(txtFrom.Text);
            int to = Convert.ToInt32(txtTo.Text);
            string oddNumberString = "";
            for(int i = from; i <= to; i++)
            {
                if(i % 2 != 0)
                {
                    oddNumberString += i + " ";
                }
            }
            MessageBox.Show(oddNumberString, "Even number");
        }

        private void ShowEvenNum_Click(object sender, EventArgs e)
        {
            int from = Convert.ToInt32(txtFrom.Text);
            int to = Convert.ToInt32(txtTo.Text);
            string evenNumberString = "";
            for(int i = from; i <= to; i++)
            {
                if(i % 2 == 0)
                {
                    evenNumberString += i + " ";
                }
            }
            MessageBox.Show(evenNumberString, "Even number");
        }
    }
}
