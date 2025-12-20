using System;

class TimeAndDis
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("From city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("To city: ");
        string toCity = Console.ReadLine();

        Console.Write("Distance from to via : ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Time Taken FromToVia (hours): ");
        double timeFromToVia = double.Parse(Console.ReadLine());

        Console.Write("Distance via to final city : ");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.Write("Time taken via to final city: ");
        double timeViaToFinalCity = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double timeTaken = timeFromToVia + timeViaToFinalCity;
    

        Console.WriteLine("The results of the trip are " + totalDistance + " km and " + timeTaken + " hours");
    }
}
