using System;
class HeightMeasure
{
    static void Main()
    {
        Console.WriteLine("Enter the height in cm: ");
        double heightCm = double.Parse(Console.ReadLine());

        double totalInches = heightCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;

        Console.WriteLine("The height in cm is " + heightCm + "  while in feet is " + feet + " and inches is " + inches);

    }
}