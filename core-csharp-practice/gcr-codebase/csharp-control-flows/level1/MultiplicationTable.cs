using System;

class MultiplicationTable
{
    static void Main()
    {

        // Take input for number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());


        //print from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(number + " * " + i + " = " + (number * i));
        }
    }
}
