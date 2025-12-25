using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class NumberOfHandshakes
    {
        //method to calculate handshakes
        static int Handshakes(int n)
        {
            return (n * (n - 1)) / 2;
        }
        static void Main()
        {
            //take input for numbers
            Console.WriteLine("Enter number of students: ");
            int students = int.Parse(Console.ReadLine());

            // Calculate handshakes
            int handshakes = Handshakes(students);

            // Print result
            Console.WriteLine("Maximum handshakes = " + handshakes);

        }
    }
}
