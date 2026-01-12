using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkthrough4CircleApp
{
    public class Circle
    {
        public double radius;
        public double GetDiameter()
        {
            return 2 * radius;
        }
        public double GetPerimeter()
        {
            return Math.PI * GetDiameter();
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
