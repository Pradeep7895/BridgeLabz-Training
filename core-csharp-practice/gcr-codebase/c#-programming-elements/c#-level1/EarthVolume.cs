using System;
class EarthVolume
{
    static void Main()
    {
        double radiusKm = 6378;

        double volumeKm3 = (4.0 / 3.0) * 3.141 * Math.Pow(radiusKm, 3);

        // Convert km to miles (1 km = 0.621371 miles)
        double radiusMiles = radiusKm * 0.621371;
        double volumeMiles3 = (4.0 / 3.0) * 3.141 * Math.Pow(radiusMiles, 3);

        Console.WriteLine("The volume of earth in cubic kilometers is: " + volumeKm3 + "and in cubic miles is: " + volumeMiles3);
    }
}