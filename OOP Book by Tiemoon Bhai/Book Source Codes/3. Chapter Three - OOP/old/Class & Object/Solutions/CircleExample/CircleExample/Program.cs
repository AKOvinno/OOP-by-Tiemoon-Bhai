using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of a circle:");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle aCircle = new Circle(radius);
            Console.WriteLine("Circle inforation:");
            Console.WriteLine("Radius: " + aCircle.Radius + " Diameter: " + aCircle.GetDiameter());
            Console.WriteLine("Perimeter: " + aCircle.GetPerimeter() + " Area: " + aCircle.GetArea());
            Console.ReadKey();
        }
    }
}
