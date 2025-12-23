using System;
class LargestOfThree
{
    static void Main(string[] args)
    {
        //Enter first Number
        Console.WriteLine("Enter first Number:");
        int number1 = int.Parse(Console.ReadLine());

        //Enter second Number
        Console.WriteLine("Enter second Number:");  
        int number2 = int.Parse(Console.ReadLine());

        //Enter third Number
        Console.WriteLine("Enter third Number:");
        int number3 = int.Parse(Console.ReadLine());

        //Find the largest number among three numbers
        bool isFirstLargest = (number1 > number2) && (number1 > number3);
        bool isSecondLargest = (number2 > number1) && (number2 > number3);
        bool isThirdLargest = (number3 > number1) && (number3 > number2);

        Console.WriteLine("Is the first number the largest? " + isFirstLargest);
        Console.WriteLine("Is the second number the largest? " + isSecondLargest);
        Console.WriteLine("Is the third number the largest? " + isThirdLargest);
    }
}