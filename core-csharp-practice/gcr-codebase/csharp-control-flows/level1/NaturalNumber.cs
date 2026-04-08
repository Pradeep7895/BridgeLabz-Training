using System;
class NaturalNumber
{
    static void Main(string[] args)
    {
        //Enter a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        //Check if the number is a natural number
        if (number > 0)
        {
            //Calculate the sum of natural numbers up to the given number
            int sum=number*(number+1)/2;
            Console.WriteLine("The sum of" + number + " natural numbers is: " + sum);
        }
        else
        {
            Console.WriteLine("The number" + number + " is not a natural number");
        }
    }
}