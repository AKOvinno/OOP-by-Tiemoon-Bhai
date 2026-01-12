using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureConverter
{
    public partial class TemperatureConverterUI : Form
    {
        TemperatureConverter aTemperatureConverter = new TemperatureConverter();
        public TemperatureConverterUI()
        {
            InitializeComponent();
        }

        private void FahrenheitToCelciusButton_Click(object sender, EventArgs e)
        {
            aTemperatureConverter.temperature = Convert.ToDouble(TemperatureTextBox.Text);
            double CelsiusTemperature = aTemperatureConverter.FahrenheitToCelsius(aTemperatureConverter.temperature);
            string status = aTemperatureConverter.TemperatureStatus(aTemperatureConverter.temperature);
            MessageBox.Show(aTemperatureConverter.temperature + "F = " + CelsiusTemperature + "C" + "\n" + status );
        }

        private void CelciusToFahrenheitButton_Click(object sender, EventArgs e)
        {
            aTemperatureConverter.temperature = Convert.ToDouble(TemperatureTextBox.Text);
            double FahrenheitTemperature = aTemperatureConverter.CelsiusToFahrenheit(aTemperatureConverter.temperature);
            string status = aTemperatureConverter.TemperatureStatus(aTemperatureConverter.temperature);
            MessageBox.Show(aTemperatureConverter.temperature + "C = " + FahrenheitTemperature + "F" + "\n" + status);
        }
    }
}
