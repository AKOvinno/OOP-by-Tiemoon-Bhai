using System;
using System.Windows.Forms;

namespace CalculatorApp
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
        Calculator calculatorObj = new Calculator();

        private void addButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculatorObj.Add(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculatorObj.Subtract(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculatorObj.Multiply(firstNumber, secondNumber);
            resultTextBox.Text = result.ToString();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
            secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
            result = calculatorObj.Divide(firstNumber, secondNumber);          
            resultTextBox.Text = result.ToString();
        }
    }
}
