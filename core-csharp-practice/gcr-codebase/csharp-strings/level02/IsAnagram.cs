using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class IsAnagram
    {
        static void Main(string[] args)
        {
            //input two string
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            //if the string length is not SafeMemoryMappedFileHandle it is not possible
            if (a.Length != b.Length)
            {
                Console.WriteLine(false);
                return;
            }
            bool f = true;

            // check for each letter the count in both the string
            for (int i = 0; i < a.Length; i++)
            {
                int ca = 0, cb = 0;
                for (int j = 0; j < a.Length; j++)
                {
                    // count the occurence of a[i] in both the string
                    if (a[i] == a[j]) ca++;
                    if (a[i] == b[j]) cb++;
                }
                if (ca != cb)
                {
                    f = false;
                    break;
                }
            }
            Console.WriteLine(f);
        }
    }
}
