using System;
class AreaOfTriangle
{
    static void Main()
    {
        Console.Write("Enter base of the triangle (in inches): ");
        double baseInches = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter height of the triangle (in inches): ");
        double heightInches = Convert.ToDouble(Console.ReadLine());

        double areaSquareInches = 0.5 * baseInches * heightInches;

        // 1 inch = 2.54 cm → 1 sq inch = 2.54 * 2.54 sq cm
        double areaSquareCm = areaSquareInches * 2.54 * 2.54;

        Console.WriteLine("the area of triangle in square inches is: " + areaSquareInches + " and in square centimeters is: " + areaSquareCm);
    }
}