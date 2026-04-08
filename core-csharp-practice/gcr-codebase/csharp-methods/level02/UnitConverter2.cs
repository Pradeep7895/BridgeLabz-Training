using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class UnitConverter2
    {

        // Method to convert yards to feet
        public static double ConvertYardsToFeet(double value)
        {
            return value * 3;
        }

        // Method to convert feet to yards
        public static double ConvertFeetToYards(double value)
        {
            return value * 0.333333;
        }

        // Method to convert meters to inches
        public static double ConvertMetersToInches(double value)
        {
            return value * 39.3701;
        }

        // Method to convert inches to meters
        public static double ConvertInchesToMeters(double value)
        {
            return value * 0.0254;
        }

        // Method to convert inches to centimeters
        public static double ConvertInchesToCm(double value)
        {
            return value * 2.54;
        }
        static void Main()
        {
            // Take yards input
            Console.Write("Enter value in yards: ");
            double yards = double.Parse(Console.ReadLine());

            // Take feet input
            Console.Write("Enter value in feet: ");
            double feet = double.Parse(Console.ReadLine());

            // Take meters input
            Console.Write("Enter value in meters: ");
            double meters = double.Parse(Console.ReadLine());

            // Take inches input
            Console.Write("Enter value in inches: ");
            double inches = double.Parse(Console.ReadLine());

            // Display converted results
            Console.WriteLine("\nConverted Values:");
            Console.WriteLine("Yards to Feet = " + ConvertYardsToFeet(yards));
            Console.WriteLine("Feet to Yards = " + ConvertFeetToYards(feet));
            Console.WriteLine("Meters to Inches = " + ConvertMetersToInches(meters));
            Console.WriteLine("Inches to Meters = " + ConvertInchesToMeters(inches));
            Console.WriteLine("Inches to Centimeters = " + ConvertInchesToCm(inches));
        }
    }
}
