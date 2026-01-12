using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionOfPractice2
{
    class Laptop
    {
        public string brandName;
        public int ramSizeInGB;
        public int numberOfCore;

        public string GetInfoWhetherItIsGoodForProgrammer()
        {
            if (ramSizeInGB >= 8 && numberOfCore >= 8)
            {
                return "This laptop is appropriate for a programmer";
            }
            else
            {
                return "Laptop with this configuration is not appropriate for a programmer";
            }
        }
    }
}
