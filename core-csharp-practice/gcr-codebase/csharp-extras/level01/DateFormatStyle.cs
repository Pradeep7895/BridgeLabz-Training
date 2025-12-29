using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level01
{
    internal class DateFormatStyle
    {
        static void Main(string[] args)
        {
            // inputing date
            DateTime d = DateTime.Now;


            //showing differnt format of showing date
            Console.WriteLine(d.ToString("dd/MM/yyyy"));
            Console.WriteLine(d.ToString("yyyy-MM-dd"));
            Console.WriteLine(d.ToString("ddd, MMM dd, yyyy"));
        }
    }
}
