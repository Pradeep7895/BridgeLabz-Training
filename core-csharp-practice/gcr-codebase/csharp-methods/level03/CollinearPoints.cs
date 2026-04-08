using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level03
{
    internal class CollinearPoints
    {
        //check collinearity using slope
        // collinear if slope AB = slope BC = slope AC
        public static bool CollinearUsingSlope(
            double x1, double y1,
            double x2, double y2,
            double x3, double y3)
        {
            // Check for vertical lines 
            if ((x2 - x1) == 0 || (x3 - x2) == 0 || (x3 - x1) == 0)
            {
                // If all x-coordinates are same, points are collinear
                return (x1 == x2 && x2 == x3);
            }

            // Calculate slopes
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);
            double slopeAC = (y3 - y1) / (x3 - x1);

            // Compare slopes
            return slopeAB == slopeBC && slopeBC == slopeAC;
        }

        //check collinearity using triangle formula
        
        public static bool CollinearUsingArea(
            double x1, double y1,
            double x2, double y2,
            double x3, double y3)
        {
            double area = 0.5 *
                (x1 * (y2 - y3)
               + x2 * (y3 - y1)
               + x3 * (y1 - y2));

            // If area is zero, points are collinear
            return area == 0;
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

            // Take input for third point
            Console.Write("Enter x3: ");
            double x3 = double.Parse(Console.ReadLine());
            Console.Write("Enter y3: ");
            double y3 = double.Parse(Console.ReadLine());


            //  using slope method
            bool slopeResult = CollinearUsingSlope(x1, y1, x2, y2, x3, y3);


            //  using area method
            bool areaResult = CollinearUsingArea(x1, y1, x2, y2, x3, y3);

            // Display results
            Console.WriteLine("\n Results :");
            Console.WriteLine("Collinear by Slope Method: " + slopeResult);
            Console.WriteLine("Collinear by Area Method : " + areaResult);

            
            if (slopeResult && areaResult)
                Console.WriteLine("The given three points are COLLINEAR.");
            else
                Console.WriteLine("The given three points are NOT collinear.");
        }

    }
}
        