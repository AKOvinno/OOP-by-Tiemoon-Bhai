using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    internal class TemperatureConverter
    {
        public double temperature;
        public double FahrenheitToCelsius(double temperature)
        {
            return ((temperature - 32.0) * 5) /9;
        }
        public double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }
        public string TemperatureStatus(double temperature)
        {
            if (temperature < 0) return "Extreme Cold";
            else if (temperature >= 0 && temperature <= 10) return "Very Cold";
            else if (temperature >= 11 && temperature <= 15) return "Cold";
            else if (temperature >= 16 && temperature <= 25) return "Warm";
            else if (temperature >= 26 && temperature <= 30) return "Hot";
            else if (temperature >= 31 && temperature <= 45) return "Very Hot";
            else if (temperature >= 46) return "Extreme Hot";
            else return "Invalid Temperature";
        }
    }
}
