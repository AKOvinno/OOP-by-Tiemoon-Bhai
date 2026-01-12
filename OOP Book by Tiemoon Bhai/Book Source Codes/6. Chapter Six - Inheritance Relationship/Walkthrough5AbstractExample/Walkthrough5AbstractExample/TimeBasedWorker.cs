using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough5AbstractExample
{
    class TimeBasedWorker : Worker
    {
        public int TotalHoursWorked { set; get; }
        public double AmountPerHour { set; get; }

        public override double GetTotalWage()
        {
            return TotalHoursWorked * AmountPerHour;
        }
    }
}
