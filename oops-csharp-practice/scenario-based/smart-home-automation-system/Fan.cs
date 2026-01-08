using BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    //implements base class, and interface
    internal class Fan : Appliance, IControllable
    {
        //speed of fan on scale of 1-5
        private int Speed; 

        //constructor
        public Fan(string name, string location, int speed)
            : base(name, location)
        {
            Speed = speed;
        }
        //turn on method override
        public void TurnOn()
        {
            SetStatus(true);
            Console.WriteLine("Fan is ON");
            Console.WriteLine("Location: " + GetLocation());
            Console.WriteLine("Turning Speed: " + Speed );
        }
        //turn off method override
        public void TurnOff()
        {
            SetStatus(false);
            Console.WriteLine("Fan is OFF");
        }
    }

}
