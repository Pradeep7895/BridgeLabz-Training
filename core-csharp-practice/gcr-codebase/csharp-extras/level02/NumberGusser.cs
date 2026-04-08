using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level02
{
    internal class NumberGusser
    {
        static void Main(string[] args)
        {
            // taking the user input
            int user = Convert.ToInt32(Console.ReadLine());
            int low = 1;
            int high = 100;
            Random r = new Random();

            while (true)
            {
                // computer guessing 
                int guess = Guessing(low, high, r);
                Console.WriteLine(guess);

                string f = Console.ReadLine();

                // if right print correct 
                if (f == "correct")
                {
                    break;
                }

                // if the guess is high write high or if less write low
                if (f == "high")
                {
                    high = guess - 1;
                }
                if (f == "low")
                {
                    low = guess + 1;
                }
            }
        }
        // computer guessing function
        static int Guessing(int l, int h, Random r)
        {
            return r.Next(l, h + 1);
        }
    }
}
