using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough3BankSeveralCurrency
{
    public class CurrencyConverter
    {
        double valueOfOneUSDInBDT = 83.92;
        public double ConvertToUSD(double amountInBDT)
        {
            return amountInBDT / valueOfOneUSDInBDT;
        }
    }
}
