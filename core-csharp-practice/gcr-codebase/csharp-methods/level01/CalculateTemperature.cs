using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class CalculateTemperature
    {
        // Method to calculate wind chill
        public static double CalculateWindChill(double temp, double windSpeed)
        {
            // Wind chill formula
            return 35.74 + 0.6215 * temp +
                   (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);
        }
        static void Main()
        {
            // Input temperature
            Console.Write("Enter temperature: ");
            double temperature = double.Parse(Console.ReadLine()!);

            // Input wind speed
            Console.Write("Enter wind speed: ");
            double windSpeed = double.Parse(Console.ReadLine()!);

            // Display wind chill
            Console.WriteLine("Wind Chill = " + CalculateWindChill(temperature, windSpeed));
        }
    }
}
