namespace CircleExample
{
    public class Circle
    {
        private double radius;
        private const double PI = 3.14;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetPerimeter()
        {
            return PI*Diameter;
        }

        public double GetArea()
        {
            return PI*Radius*Radius;
        }

        public double Diameter
        {
            get { return 2*Radius; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
}
