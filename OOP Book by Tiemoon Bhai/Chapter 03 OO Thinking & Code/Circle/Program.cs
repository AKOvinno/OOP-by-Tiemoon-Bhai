namespace Circle
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
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the radius of a circle: ");
                string radiusInString = Console.ReadLine();
                double radius = Convert.ToDouble(radiusInString);
                Circle aCircle = new Circle();
                aCircle.radius = radius;
                Console.WriteLine("Diameter: " + aCircle.GetDiameter());
                Console.WriteLine("Perimeter: " + aCircle.GetPerimeter());
                Console.WriteLine("Area: " + aCircle.GetArea());
                Console.WriteLine();
                Console.WriteLine("Want to do it again? press Y");
                string Key = Console.ReadLine();
                if (Key.ToUpper() != "Y") break;
            }
        }
    }
}
