using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorUI : Form
    {
        public CalculatorUI()
        {
            InitializeComponent();
        }
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        Calculator aCalculator = new Calculator();
        private void AddButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(FirstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(SecondNumberTextBox.Text);
            result = aCalculator.Add(firstNumber, secondNumber);
            ResultTextBox.Text = result.ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(FirstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(SecondNumberTextBox.Text);
            result = aCalculator.Subtract(firstNumber, secondNumber);
            ResultTextBox.Text = result.ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(FirstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(SecondNumberTextBox.Text);
            result = aCalculator.Multiply(firstNumber, secondNumber);
            ResultTextBox.Text = result.ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(FirstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(SecondNumberTextBox.Text);
            result = aCalculator.Divide(firstNumber, secondNumber);
            ResultTextBox.Text = result.ToString();
        }
    }
}
