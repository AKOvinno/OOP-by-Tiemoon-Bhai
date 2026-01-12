using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough2MethodOverload
{
    class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }
        public double Add(double number1, double number2, double number3)
        {
            //return Add(Add(number1, number2), number3);
            return number1 + number2 + number3;
        }

        public double Subtract(double number1 , double number2)
        {
            return number1 - number1;   
        }

        public double Calculate(string operationName, double no1, double no2)
        {
            if (operationName.ToUpper() == "ADD"){
                return no1 + no2;
            }
            else if (operationName.ToUpper() == "SUBTRACT")
            {
                return no1 - no2;
            }
            else
            {
                throw new Exception("Operation failed");
            }
        }



    }
}
