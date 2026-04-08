using System;
class FirstIsSmallest
{
    static void Main(string[] args)
    {
        //Read inputs from user
        //Enter the first number
        Console.WriteLine("Enter first number:");
        int number1 = int .Parse(Console.ReadLine());

        //Enter the second number
        Console.WriteLine("Enter second Number:");
        int number2 = int.Parse(Console.ReadLine());

        //Enter the third number
        Console.WriteLine("Enter third Number:");
        int number3 = int.Parse(Console.ReadLine());    

        //Check if first number is smallest
        bool isSmallest = (number1 < number2) && (number1 < number3);

        //Display result
        Console.WriteLine("Is the first number the smallest? " + isSmallest);
    }
}