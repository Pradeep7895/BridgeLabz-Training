using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class UnitConverter3
    {

        // Method to convert Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        // Method to convert Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Method to convert pounds to kilograms
        public static double PoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }

        // Method to convert kilograms to pounds
        public static double KilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }

        // Method to convert gallons to liters
        public static double GallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }

        // Method to convert liters to gallons
        public static double LitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
        static void Main()
        {

            // Take temperature inputs
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            // Take weight inputs
            Console.Write("Enter weight in pounds: ");
            double pounds = double.Parse(Console.ReadLine());

            Console.Write("Enter weight in kilograms: ");
            double kilograms = double.Parse(Console.ReadLine());

            // Take volume inputs
            Console.Write("Enter volume in gallons: ");
            double gallons = double.Parse(Console.ReadLine());

            Console.Write("Enter volume in liters: ");
            double liters = double.Parse(Console.ReadLine());


            // Display converted values
            Console.WriteLine("\nConverted Values:");
            Console.WriteLine("Fahrenheit to Celsius = " + FahrenheitToCelsius(fahrenheit));
            Console.WriteLine("Celsius to Fahrenheit = " + CelsiusToFahrenheit(celsius));
            Console.WriteLine("Pounds to Kilograms = " + PoundsToKilograms(pounds));
            Console.WriteLine("Kilograms to Pounds = " + KilogramsToPounds(kilograms));
            Console.WriteLine("Gallons to Liters = " + GallonsToLiters(gallons));
            Console.WriteLine("Liters to Gallons = " + LitersToGallons(liters));
        }
    }
}
