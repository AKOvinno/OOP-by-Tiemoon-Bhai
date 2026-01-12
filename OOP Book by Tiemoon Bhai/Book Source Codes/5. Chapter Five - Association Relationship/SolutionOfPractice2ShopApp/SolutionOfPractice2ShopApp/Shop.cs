using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfPractice2ShopApp
{
    class Shop
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public List<Product> Products { set; get; }

        public Shop()
        {
            Products = new List<Product>();
        }

    }
}
