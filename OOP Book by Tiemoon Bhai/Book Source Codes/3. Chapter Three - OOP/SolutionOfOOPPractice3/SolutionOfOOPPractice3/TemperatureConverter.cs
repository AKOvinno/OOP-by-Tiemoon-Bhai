using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfOOPPractice3
{
    class TemperatureConverter
    {
        public double ConvertFahrenheitToCelsius(double temperature)
        {
            return (temperature - 32) * (5.0 / 9);
        }

        public double ConvertCelsiusToFahrenheit(double temperature)
        {
            return temperature * (9.0 / 5) + 32;
        }

        public string GetFeeling(double temperatureInCelcius)
        {
            if (temperatureInCelcius >= 45)
            {
                return "Extremely Hot";
            }
            else if (temperatureInCelcius >= 31 && temperatureInCelcius < 45)
            {
                return "Very Hot";
            }
            else if (temperatureInCelcius >= 26 && temperatureInCelcius < 31)
            {
                return "Hot";
            }
            else if (temperatureInCelcius >= 16 && temperatureInCelcius < 26)
            {
                return "Warm";
            }
            else if (temperatureInCelcius >= 11 && temperatureInCelcius < 16)
            {
                return "Cool";
            }
            else if (temperatureInCelcius >= 0 && temperatureInCelcius < 11)
            {
                return "Cold";
            }
            else
            {
                return "Very Cold";
            }        
        }
    }
}
