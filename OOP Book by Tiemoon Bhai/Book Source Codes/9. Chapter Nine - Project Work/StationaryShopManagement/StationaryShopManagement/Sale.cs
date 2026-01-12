using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement
{
    class Sale : OperationOnProduct
    {
        public double TotalAmount { set; get; }
        public override string GetBasicInfo()
        {
            return base.GetBasicInfo() + " || " + TotalAmount;
        }
    }
}
