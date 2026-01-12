using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough1Inheritance1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop aLaptop = new Laptop();
            aLaptop.Manufacturer = "Dell";
            aLaptop.ModelName = "XPS 13";
            aLaptop.RAMSizeInGB = 8;
            aLaptop.ProcessorSpeedInGHz = 3.5;
            aLaptop.UnitPrice = 80000;
            aLaptop.CounrtyOfOrigin = "USA";
            double netPayeable = aLaptop.GetUnitPriceAfterDiscount(5);
            Console.WriteLine(netPayeable);
            Console.ReadKey();
        }
    }
}
