using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_objects.level01
{
    internal class AreaOfCircle
    {
        //field
        private double radius;
        private const double PI = 3.14;

        // Constructor
        public AreaOfCircle(double radius)
        {
            this.radius = radius;
        }
        //method to calculate area of circle
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        //method to display area of circle
        public void DisplayArea()
        {
            double area = CalculateArea();
            Console.WriteLine("Area of Circle with radius " + radius + " is: " + area);
        }
        public static void Main(string[] args)
        {
            AreaOfCircle area = new AreaOfCircle(5.0);
            area.DisplayArea();
        }
    }
}
