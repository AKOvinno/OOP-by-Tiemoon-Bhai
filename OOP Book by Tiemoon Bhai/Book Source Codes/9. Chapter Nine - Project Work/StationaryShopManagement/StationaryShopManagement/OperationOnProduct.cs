using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryShopManagement
{
    class OperationOnProduct
    {
        public Product Product { set; get; }
        public int Quantity { set; get; }
        public DateTime OperationDate { set; get; }
        public virtual string GetBasicInfo()
        {
            return Product.Name + " || " + Product.Code + " || " + Quantity;
        }
    }
}
