using System;
class QuoAndRem
{
    static void Main()
    {
        Console.Write("Enter the num1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the num2: ");
        int num2 = int.Parse(Console.ReadLine());

        // Calculate quotient and remainder
        int quotient = num1 / num2;
        int remainder = num1 % num2;

        Console.WriteLine("The quotient is " + quotient + " and the remainder is " + remainder + " of two numbers " + num1 + " and " + num2);

    }
}