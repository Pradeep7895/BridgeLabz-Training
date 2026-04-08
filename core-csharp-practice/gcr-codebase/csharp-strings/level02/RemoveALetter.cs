using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.strings.level02
{
    internal class RemoveALetter
    {
        static void Main(string[] args)
        {
            // input teh string 
            string s = Console.ReadLine();
            char r = Console.ReadLine()[0];
            string t = "";


            // remove the given letter from the string
            for (int i = 0; i < s.Length; i++)
            {
                // if the char is not the given char add it to the result string
                if (s[i] != r)
                {
                    t += s[i];
                }
            }
            // print the result string
            Console.WriteLine(t);
        }
    }
}
