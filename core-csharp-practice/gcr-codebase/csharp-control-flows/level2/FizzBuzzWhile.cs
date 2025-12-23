using System;

class FizzBuzzWhile
{
    static void Main()
    {
        //Take input from user
        Console.Write("Enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int i = 1;
        //Print FizzBuzz series up to n using while loop
        if(n > 0)
        {
            while(i <= n)
            {
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if(i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

                i++;
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
