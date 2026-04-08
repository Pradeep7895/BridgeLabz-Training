using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level01
{
    internal class ForwardInTime
    {
        static void Main(string[] args)
        {
            //inputing the date 
            DateTime curDate = Convert.ToDateTime(Console.ReadLine());


            //moving forward in time by adding days, months and years
            curDate = curDate.AddDays(7);

            curDate = curDate.AddMonths(1);

            curDate = curDate.AddYears(2);

            curDate = curDate.AddDays(-21);

            //printing the new date
            Console.WriteLine(curDate);
        }
    }
}
