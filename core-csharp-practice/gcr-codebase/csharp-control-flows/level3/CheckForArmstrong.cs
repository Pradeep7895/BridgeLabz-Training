using System;

class CheckForArmstrong
{
    static void Main()
    { 
        
        // Input number from user
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Store the original number to compare later
        int original = number;
        int sum = 0;
        
        // Calculate the sum of cubes of each digit
        while(original != 0)
        {

            // Extract the last digit
            //calculate remainder by modulus operator
            int remainder = original % 10;

            // Calculate cube and add to sum
            sum = sum + (remainder * remainder * remainder);

            // Remove the last digit
            original = original / 10;
        }


        //check if the sum is equal to the original number
        if(sum == number)
            Console.WriteLine(number + " is an Armstrong Number");
        else
            Console.WriteLine(number + " is NOT an Armstrong Number");
    }
}
