using Collections.collection_csharp_practice.gcr_codebase.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.exceptions
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }
    internal class HandlingCustomException
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                ValidateAge(age);
                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException)
            {
                Console.WriteLine("Age must be 18 or above");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number");
            }
        }

        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Invalid age");
            }
        }

    }
}

   