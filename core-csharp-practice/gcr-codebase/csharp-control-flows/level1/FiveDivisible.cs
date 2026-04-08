using System;
class FiveDivisible
{
    static void Main(string[] args)
    {
        //Read input from user
        Console.WriteLine("Enter a number: ");
        int number= int.Parse(Console.ReadLine());

        // check if number is divisible by 5 or not
        if(number % 5 == 0)
        {
            //if divisible by 5
            Console.WriteLine("The number is divisible by 5.");
        }
        else
        {
            //not divisible by 5
            Console.WriteLine("The number is not divisible by 5.");
        }

    }
}