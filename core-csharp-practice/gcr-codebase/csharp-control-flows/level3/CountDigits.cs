using System;

class CountDigits
{
    static void Main()
    {

        // Input number from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        // Initialize count to 0
        int count = 0;
        
        // Count the digits
        while(number != 0)
        {
            // Remove the last digit
            number = number / 10;
            // Increment count
            count++;
        }

        Console.WriteLine("Number of digits = " + count);
    }
}
