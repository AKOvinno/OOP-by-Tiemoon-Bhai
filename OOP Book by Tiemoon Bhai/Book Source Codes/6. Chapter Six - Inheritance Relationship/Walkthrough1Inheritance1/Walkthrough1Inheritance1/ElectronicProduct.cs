using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough1Inheritance1
{
    class ElectronicProduct
    {
        public string Manufacturer { set; get; }
        public string CounrtyOfOrigin { set; get; }
        public double UnitPrice { set; get; }

        public double GetUnitPriceAfterDiscount(double discountPercent)
        {
            return UnitPrice - (UnitPrice * discountPercent) / 100;
        }
    }
}
