using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.senario_based.AeroVigil
{
    internal interface IFlight
    {
        bool ValidateFlightNumber(String flightNumber);
        bool ValidateFlightName(String flightName);
        bool ValidatePassengerCount(int passengerCount, String flightName);
        double CalculateFuelToFillTank(String flightName, double currentFuelLevel);

    }
}