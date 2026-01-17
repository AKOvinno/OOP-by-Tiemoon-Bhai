using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastBankSolution
{
    internal class CurrencyConverter
    {
        double ValueOfOneUSDInBDT = 120.00;
        public double ConvertToUSD(double amountInBDT)
        {
            return amountInBDT / ValueOfOneUSDInBDT;
        }
    }
}
