using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class TrigonometricFunctions
    {

        // Method to calculate sin, cos, tan
        public static double[] calculateTrigonometricFunctions(double angle)
        {
            //  degrees to radians
            double radians = angle * Math.PI / 180;

            // Return sin, cos, tan values
            return new double[]
            {
            Math.Sin(radians),
            Math.Cos(radians),
            Math.Tan(radians)
            };
        }

        static void Main()
        {

            // Input angle
            Console.Write("Enter angle in degrees: ");
            double angle = double.Parse(Console.ReadLine());

            // Call method
            double[] result = calculateTrigonometricFunctions(angle);

            // Print trigonometric values
            Console.WriteLine("Sin = " + result[0]);
            Console.WriteLine("Cos = " + result[1]);
            Console.WriteLine("Tan = " + result[2]);
        }


    }
}
