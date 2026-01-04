using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level01
{
    internal class Circle
    {
        private double radius;
        private const double PI = 3.14;

        //default constructor
        public Circle()
        {
            radius = 2.0;
        }

        //parameterized constructors
        public Circle(double radius) : this()
        {
            if(radius > 0 )
                this.radius = radius;
        }
        //method to calculate area
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        //method to display 
        public void Display()
        {
            Console.WriteLine("\nDisplay Details: ");
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + CalculateArea());
        }

        public static void Main(string[] args)
        {
            //using default constructor
            Circle circle1 = new Circle();
            circle1.Display();

            //using parameterized constructor
            Circle circle2 = new Circle(5.0);
            circle2.Display();
        }
    }
}
