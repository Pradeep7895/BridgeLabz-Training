using System;
class KiloToMiles
{
    static void Main()
    {
        // Input in kilometers
        Console.WriteLine("Enter the value in kilometers: ");
        double Km=Convert.ToDouble(Console.ReadLine());
        
        //1 mile = 1.6 km
        double miles=Km*0.621371;
        Console.WriteLine("The total miles is : " + miles + "mile for the given " + Km + " km");
    }
}