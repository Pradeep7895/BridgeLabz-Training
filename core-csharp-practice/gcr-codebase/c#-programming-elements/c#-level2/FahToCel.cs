using System;

class FahToCel
{
    static void Main()
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = double.Parse(Console.ReadLine());

        double celsius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius");
    }
}
