using System;

class CelToFah
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("The " + celsius + "  Celsius is " + fahrenheit + " Fahrenheit.");
    }
}
