using System;

namespace CircleExample
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetPerimeter()
        {
            return Math.PI*GetDiameter();
        }

        public double GetArea()
        {
            return Math.PI*Radius*Radius;
        }

        public double GetDiameter()
        {
            return 2*Radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
}
