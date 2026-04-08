using System;

class FizzBuzz
{
    static void Main()
    {
        //Take input from user
        Console.Write("Enter a positive number: ");
        int n = int.Parse(Console.ReadLine());

        
        //Print FizzBuzz series up to n using for loop
        if(n> 0)
        {
            for(int i = 1; i <= n; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if(i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Please enter a positive integer.");
        }
    }
}
