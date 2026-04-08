using System;

class SumZeroWhile
{
    static void Main(string[] args)
    {
        // Initialize total
        double total = 0.0;


        // Loop indefinitely
        while(true)
        {   
            
            // Take input from user
            Console.Write("Enter a number (0 or negative to stop): ");
            double num = double.Parse(Console.ReadLine());

            if(num <= 0)
                break;
            

            // Add number to total
            total += num;
        }

        Console.WriteLine("Total Sum = " + total);
    }
}
