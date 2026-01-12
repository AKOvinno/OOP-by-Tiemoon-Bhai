using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement
{
    class Product
    {
        public string Name { set; get; }
        public string Code { set; get; }
        public int Quantity { set; get; }
        public double UnitPrice { set; get; }

        public Product(string name, string code, double unitPrice)
        {
            Name = name;
            Code = code;
            UnitPrice = unitPrice;
        }

        public Product()
        {
 
        }
    }
}
