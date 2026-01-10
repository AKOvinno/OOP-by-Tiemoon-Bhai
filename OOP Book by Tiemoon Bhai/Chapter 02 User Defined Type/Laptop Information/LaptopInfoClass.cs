using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Information
{
    internal class LaptopInfoClass
    {
        public string BrandName;
        public int RamSize;
        public int ProcessorCore;

        public string sAppropriateForProgrammer()
        {
            if (RamSize >= 8 && ProcessorCore >= 5) return "This Laptop is appropriate for a programmer";
            return "No, It's not.";
        }
    }
}
