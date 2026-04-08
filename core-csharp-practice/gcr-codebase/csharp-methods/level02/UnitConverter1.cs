using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class UnitConverter1
    {

        // Method to convert kilometers to miles
        public static double ConvertKmToMiles(double value)
        {
            return value * 0.621371;
        }

        // Method to convert miles to kilometers
        public static double ConvertMilesToKm(double value)
        {
            return value * 1.60934;
        }

        // Method to convert meters to feet
        public static double ConvertMetersToFeet(double value)
        {
            return value * 3.28084;
        }

        // Method to convert feet to meters
        public static double ConvertFeetToMeters(double value)
        {
            return value * 0.3048;
        }

        static void Main()
        {
            // Take kilometer input
            Console.Write("Enter distance in kilometers: ");
            double km = double.Parse(Console.ReadLine());

            // Take miles input
            Console.Write("Enter distance in miles: ");
            double miles = double.Parse(Console.ReadLine());

            // Take meters input
            Console.Write("Enter distance in meters: ");
            double meters = double.Parse(Console.ReadLine());

            // Take feet input
            Console.Write("Enter distance in feet: ");
            double feet = double.Parse(Console.ReadLine());

            // Call methods and display results
            Console.WriteLine("\nConverted Values : ");
            Console.WriteLine("Kilometers to Miles = " + ConvertKmToMiles(km));
            Console.WriteLine("Miles to Kilometers = " + ConvertMilesToKm(miles));
            Console.WriteLine("Meters to Feet = " + ConvertMetersToFeet(meters));
            Console.WriteLine("Feet to Meters = " + ConvertFeetToMeters(feet));
        }
    }
}
