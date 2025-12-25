using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level01
{
    internal class SpringSeason
    {
        //  To check spring season
        static bool Spring(int month, int day)
        {
            //conditions
            return (month == 3 && day >= 20) ||
                    (month == 4 || month == 5) ||
                    (month == 6 && day <= 20);
        }
        static void Main(string[] args)
        {

            // Read month from command line
            int month = int.Parse(args[0]);

            // Read day from command line
            int day = int.Parse(args[1]);

            // Check spring season
            if (Spring(month, day))
                Console.WriteLine("Its a Spring Season");
            else
                Console.WriteLine("Not a Spring Season");
        }
    }
}
