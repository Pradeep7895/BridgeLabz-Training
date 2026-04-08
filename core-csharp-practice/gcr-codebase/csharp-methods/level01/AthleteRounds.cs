using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class AthleteRounds
    {
        // Method to calculate number of rounds
        static double Rounds(double a, double b, double c)
        {
            //perimeter of triangle
            double perimeter = a + b + c;

            return 5000 / perimeter;
        }

        static void Main()
        {
            // Input triangle sides
            Console.Write("Enter side 1: ");
            double s1 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 2: ");
            double s2 = double.Parse(Console.ReadLine());

            Console.Write("Enter side 3: ");
            double s3 = double.Parse(Console.ReadLine());


            // Calculate rounds
            double rounds = Rounds(s1, s2, s3);

            // Display result
            Console.WriteLine("Number of rounds needed = " + rounds);
        }
    }
}
