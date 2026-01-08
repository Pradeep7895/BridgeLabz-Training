using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class Light : Appliance , IControllable
    {
        private int Brightness;

        public Light(string applianceName, string location, int brightness) 
            : base(applianceName, location)
        {
            Brightness = brightness;
        }
        //turn on method override
        public void TurnOn()
        {
            SetStatus(true);
            Console.WriteLine("Light is ON");
            Console.WriteLine("Location: " + GetLocation());
            Console.WriteLine("Brightness level: " + Brightness);
        }
        //turn off method override
        public void TurnOff()
        {
            SetStatus(false);
            Console.WriteLine("Light is OFF");
        }
    }
}
