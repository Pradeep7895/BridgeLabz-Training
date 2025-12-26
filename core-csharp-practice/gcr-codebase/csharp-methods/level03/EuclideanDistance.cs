using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class EuclideanDistance
    {

        // calculate Euclidean distance 
        public static double FindDistance(double x1, double y1, double x2, double y2)
        {
            
            double dx = x2 - x1;
            double dy = y2 - y1;

            return Math.Sqrt(Math.Pow(dx, 2) + Math.Pow(dy, 2));
        }

        // Method to find slope (m) and y-intercept (b)
        // index 0 -> slope (m) , index 1 -> y-intercept (b)
       
        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            // If x-coordinates are same, slope is undefined (vertical line)
            if (x2 - x1 == 0)
            {
                return new double[0]; 
            }

            double m = (y2 - y1) / (x2 - x1);

            double b = y1 - m * x1;

            return new double[] { m, b };
        }

        static void Main()
        {
            // Take input for first point
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());

            // Take input for second point
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());

            //display Euclidean distance
            double distance = FindDistance(x1, y1, x2, y2);
            Console.WriteLine("\nEuclidean Distance = " + distance);

            // Calculate slope and intercept
            double[] line = FindLineEquation(x1, y1, x2, y2);

            // Display equation of line
            if (line.Length == 0)
            {
                Console.WriteLine("Equation of line: x = " + x1 + " (Vertical Line)");
            }
            else
            {
                Console.WriteLine("Slope (m) = " + line[0]);
                Console.WriteLine("Y-Intercept (b) = " + line[1]);
                Console.WriteLine($"Equation of Line: y = {line[0]}x + {line[1]}");
            }
        }

    }
}