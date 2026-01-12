using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfPractice2ShopApp
{
    class Product
    {
        public string Code { set; get; }
        public int Quantity { set; get; }

        public Product()
        { 
        }

        public Product(string code, int quantity)
        {
            Code = code;
            Quantity = quantity;
        }
    }
}
