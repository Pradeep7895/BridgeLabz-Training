using BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class AC : Appliance, IControllable
    {
        private int Temperature;

        public AC(string name, string location, int temperature)
            : base(name, location)
        {
            Temperature = temperature;
        }
        public void TurnOn()
        {
            SetStatus(true);
            Console.WriteLine("AC is ON");
            Console.WriteLine("Location: " + GetLocation());
            Console.WriteLine("Cooling Temperature: " + Temperature + "°C");
        }

        public void TurnOff()
        {
            SetStatus(false);
            Console.WriteLine("AC is OFF");
        }
    }

}


