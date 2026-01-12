using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement
{
    class Purchase : OperationOnProduct
    {
        public string VendorName { set; get; }
        public override string GetBasicInfo()
        {
            return VendorName + " || " + base.GetBasicInfo();
        }
    }
}
