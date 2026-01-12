using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Walkthrough5AbstractExample
{
    public abstract class Worker
    {
        public string Name { set; get; }
        public string ContactNo { set; get; }
        public abstract double GetTotalWage();
    }
}
