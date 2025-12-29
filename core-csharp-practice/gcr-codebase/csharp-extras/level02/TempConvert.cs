using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.extras.level02
{
    internal class TempConvert
    {
        static void Main(string[] args)
        {
            // input teh number
            string temp = Console.ReadLine();
            double v = Convert.ToInt32(Console.ReadLine());

            if (temp == "c") Console.WriteLine(CtoF(v));
            else Console.WriteLine(FtoC(v));
        }
        // celcius to fah
        static double CtoF(double c)
        {
            return (c * 9 / 5) + 32;
        }
        // fah to celcius
        static double FtoC(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
}
