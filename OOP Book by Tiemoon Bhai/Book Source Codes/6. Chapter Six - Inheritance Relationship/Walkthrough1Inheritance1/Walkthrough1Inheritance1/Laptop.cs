using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough1Inheritance1
{
    class Laptop : ElectronicProduct
    {
        public string ModelName { set; get; }
        public int RAMSizeInGB { set; get; }
        public double ProcessorSpeedInGHz { set; get; }

    }
}
