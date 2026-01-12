using System;
using System.Windows.Forms;

namespace VariableExample3Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);
            double addResult = number1 + number2;

            MessageBox.Show(number1 + " + " + number2 + " = " + addResult);
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);
            double subtractResult = number1 - number2;
            MessageBox.Show(number1 + " - " + number2 + " = " + subtractResult);
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);
            double mutiplyResult = number1 * number2;
            MessageBox.Show(number1 + " * " + number2 + " = " + mutiplyResult);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(number1TextBox.Text);
            double number2 = Convert.ToDouble(number2TextBox.Text);
            double divideResult = number1 / number2;
            MessageBox.Show(number1 + " / " + number2 + " = " + divideResult);
        }
    }
}
