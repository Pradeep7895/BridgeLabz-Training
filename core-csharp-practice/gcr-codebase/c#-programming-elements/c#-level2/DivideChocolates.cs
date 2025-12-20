using System;

class ChocolateDistribution
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        int eachChildGets = numberOfChocolates / numberOfChildren;
        int remaining = numberOfChocolates % numberOfChildren;

        Console.WriteLine("The number of chocolates each child gets: " + eachChildGets + "and the Remaining chocolates: " + remaining);
    }
}
    