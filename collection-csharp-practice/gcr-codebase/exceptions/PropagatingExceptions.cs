using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.exceptions
{
    internal class PropagatingExceptions
    {
        static void Main()
        {
            try
            {
                Method2();
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Handled exception in Main");
            }
        }

        static void Method2()
        {
            Method1();
        }

        static void Method1()
        {
            int x = 10;
            int y = 0;
            int result = x / y;  // Runtime DivideByZeroException
        }

    }
}

  
