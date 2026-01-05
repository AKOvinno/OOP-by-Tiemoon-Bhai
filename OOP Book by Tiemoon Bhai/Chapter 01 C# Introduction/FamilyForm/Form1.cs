using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Father's Name: Md. Sirajul Haque");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mother's Name: Kamrun Naher Lily");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wife's Name: Laila Akter");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Name is Ashfaq Kadir Ovinno");
        }
    }
}
