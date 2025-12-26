using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class QuadraticEquation
    {
        //method to find roots 
        public static double[] FindRoots(double a, double b, double c)
        {
            // (delta)
            double delta = Math.Pow(b, 2) - 4 * a * c;

            // If delta is positive
            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

                return new double[] { root1, root2 };
            }
            // If delta is zero
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            // If delta is negative 
            else
            {
                return new double[0]; // empty array
            }
        }

        static void Main()
        {
            // Take input values
            Console.Write("Enter value of a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter value of b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter value of c: ");
            double c = double.Parse(Console.ReadLine());

            // Call method to find roots
            double[] roots = FindRoots(a, b, c);

            // Display result
            if (roots.Length == 2)
            {
                Console.WriteLine("Two real roots found:");
                Console.WriteLine("Root 1 = " + roots[0]);
                Console.WriteLine("Root 2 = " + roots[1]);
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("One real root found:");
                Console.WriteLine("Root = " + roots[0]);
            }
            else
            {
                Console.WriteLine("No real roots exist");
            }
        }
    }
}
