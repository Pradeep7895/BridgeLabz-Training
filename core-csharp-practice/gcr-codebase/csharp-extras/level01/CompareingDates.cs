using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level01
{
    internal class CompareingDates
    {
        static void Main(string[] args)
        {
            //taking input in datetime datetype
            DateTime a = Convert.ToDateTime(Console.ReadLine());
            DateTime b = Convert.ToDateTime(Console.ReadLine());


            //comparing the two dates
            if (a < b) Console.WriteLine("before");

            //if a is less than b then a is before b
            else if (a > b) Console.WriteLine("after");

            //if a is greater than b then a is after b
            else Console.WriteLine("same");
        }
    }
}
