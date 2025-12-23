using System;

class SumZero
{
    static void Main()
    {
        // Initialize total
        double total = 0.0;
        double num;
        

        // Take input from user
        Console.Write("Enter a number (0 to stop): ");
        num = double.Parse(Console.ReadLine());
        

        // Sum numbers until 0 is entered
        while(num != 0)
        {  
            
            // Add number to total
            total += num; 
            Console.Write("Enter a number (0 to stop): ");
            num = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total Sum = " + total);
    }
}
