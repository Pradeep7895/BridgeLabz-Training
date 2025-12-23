using System;

class CheckHarshadNumber
{
    static void Main()
    {

        // Input number from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int sum = 0;
        

        // Calculate sum of digits
        while(temp != 0)
        {
            // Extract the last digit
            int digit = temp % 10;

            // Add digit to sum
            sum += digit;

            // Remove the last digit
            temp = temp / 10;
        }

        if(number % sum == 0)
            Console.WriteLine(number + " is a Harshad Number");
        else
            Console.WriteLine(number + " is NOT a Harshad Number");
    }
}
