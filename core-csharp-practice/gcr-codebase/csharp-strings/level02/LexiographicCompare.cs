using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class LexiographicCompare
    {
        static void Main(string[] args)
        {
            //input two string
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int i = 0;

            //get to teh letter that is differnt in both the string 
            while (i < a.Length && i < b.Length && a[i] == b[i])
            {
                i++;
            }

            // if we have reached the end of both the string then they are equal
            if (i == a.Length && i == b.Length)
            {
                Console.WriteLine("equal");
            }

            // if we have reached the end of a or a[i] < b[i] then a comes before b
            else if (i == a.Length || a[i] < b[i])
            {
                Console.WriteLine(a + " comes before " + b);
            }
            // other way around 
            else
            {
                Console.WriteLine(a + " comes after " + b);
            }
        }
    }
}
