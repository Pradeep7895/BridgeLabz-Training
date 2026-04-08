using System;

class PrintOddEven
{
    static void Main()
    {

        // Take input from user
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());


        // Print odd and even numbers up to the given number
        if(number > 0)
        {
            for(int i = 1; i <= number; i++)
            {

                //print the even numbers
                if(i % 2 == 0)
                    Console.WriteLine(i + " is Even");

                //print the odd numbers    
                else
                    Console.WriteLine(i + " is Odd");
            }
        }
    }
}
