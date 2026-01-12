using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkThrough2ConstructorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item();
            item1.UnitPrice = 100;
            double discountedPriceOfItem1 = item1.GetUnitPriceAfterDiscount(15.0);
            Console.WriteLine(discountedPriceOfItem1);
            Item item2 = new Item();
            item2.UnitPrice = 200;
            double discountedPriceOfItem2 = item2.GetUnitPriceAfterDiscount(20.0);
            Console.WriteLine(discountedPriceOfItem2);
            Console.ReadKey();
        }
    }
}
