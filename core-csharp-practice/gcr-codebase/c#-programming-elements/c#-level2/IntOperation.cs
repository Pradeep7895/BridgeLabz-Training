using System;

class IntOperation
{
    static void Main()
    {
        //taking three inputs from user
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        
        // Performing operations
        int result1 = a + b * c;
        int result2 = a * b + c;
        int result3 = c + a / b;
        int result4 = a % b + c;

        Console.WriteLine("The result of Int Operations are " + result1 + ", " + result2 + ", " + result3 + " and " + result4);
    }
}
