using System;
class CheckNumber
{
    static void Main(string[] args)
    {
        //take number as input from user
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());

        //check if the number is positive, negative or zero
        if (number > 0)
        {
            Console.WriteLine("The number " + number + " is positive.");
        }
        else if(number < 0)
        {
            Console.WriteLine("The number " + number + " is negative.");
        }
        else
        {
            Console.WriteLine("The number is zero.");
        }
    }
}