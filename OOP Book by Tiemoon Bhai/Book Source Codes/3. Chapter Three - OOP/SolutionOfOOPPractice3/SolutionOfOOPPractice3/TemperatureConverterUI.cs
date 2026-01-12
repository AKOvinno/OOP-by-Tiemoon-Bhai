using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolutionOfOOPPractice3
{
    public partial class TemperatureConverterUI : Form
    {
        double input;
        TemperatureConverter converter = new TemperatureConverter();
        public TemperatureConverterUI()
        {
            InitializeComponent();
        }

        private void fahrenheitToCelsiusButton_Click(object sender, EventArgs e)
        {
            input = Convert.ToDouble(inputTextBox.Text);
            double temperatureInCelcius = converter.ConvertFahrenheitToCelsius(input);
            string feeling = converter.GetFeeling(temperatureInCelcius);
            MessageBox.Show(input + " F = " + temperatureInCelcius + " C\n" + feeling);
        }

        private void celsiusToFahrenheitButton_Click(object sender, EventArgs e)
        {
            input = Convert.ToDouble(inputTextBox.Text);
            double temperatureInFahrenheit = converter.ConvertCelsiusToFahrenheit(input);
            string feeling = converter.GetFeeling(input);
            MessageBox.Show(input + " C = " + temperatureInFahrenheit + " F\n" + feeling);
        }
    }
}
