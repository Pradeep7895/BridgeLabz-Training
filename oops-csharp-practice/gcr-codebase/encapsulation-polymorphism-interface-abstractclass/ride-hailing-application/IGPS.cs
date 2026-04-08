using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.ride_hailing_application
{
    internal interface IGPS
    {
        // Interface for GPS-related functionality

        string GetCurrentLocation();
        void UpdateLocation(string location);
    }
}
