using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance.single_inheritance
{
    //superclass
    internal class Device
    {
        public int DeviceId;
        public string Status;

        public virtual void DisplayStatus()
        {
            Console.WriteLine("Device ID: " + DeviceId);
            Console.WriteLine("Status: " + Status);
        }
        
    }
    // Subclass
    class Thermostat : Device
    {
        public int TemperatureSetting;

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Temperature Setting: " + TemperatureSetting + "°C");
        }
    }
    class Program
    {
        static void Main()
        {
            Thermostat thermostat = new Thermostat();
            thermostat.DeviceId = 101;
            thermostat.Status = "ON";
            thermostat.TemperatureSetting = 24;

            thermostat.DisplayStatus();
        }
    }
}
