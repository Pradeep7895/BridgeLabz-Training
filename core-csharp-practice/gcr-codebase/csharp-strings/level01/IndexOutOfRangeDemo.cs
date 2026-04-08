using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.strings.level01
{
    internal class IndexOutOfRangeDemo
    {
        //method to generate exception
        static void Generate()
        {
            string str = "Hello";

            // error throw IndexOutOfRangeException
            Console.WriteLine(str[10]); 
        }

        //method to hange exception
        static void Handle()
        {
            string str = "Hello";
            try
            {
                Console.WriteLine(str[10]);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught");
                Console.WriteLine("Error Message : " + ex.Message);
            }
        }
        static void Main()
        {
            //uncooment to see the exception
            //Generate();

            //to handle the exception
            Handle();

        }
    }
}
