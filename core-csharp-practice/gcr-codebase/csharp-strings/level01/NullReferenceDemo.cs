using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class NullReferenceDemo
    {
        static void Main()
        {
           
            try
            {
                string str = null;
                Console.WriteLine(str.Length);

            }
            catch (NullReferenceException e) 
            {
                Console.WriteLine("NullReferenceException caught : " + e.Message);
            }
        }
    }
}
