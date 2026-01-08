using BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    //methods to make the program user defined
    internal class ApplianceUtility
    {
        //list to add appliances into a list of interface type
        private List<IControllable> Devices = new List<IControllable>();

        //method to add light in the list
        public void AddLight()
        {
            Console.Write("Light Name: ");
            string name = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("Brightness (0-100): ");
            int brightness = int.Parse(Console.ReadLine());

            //call object of light call and add properties to list
            Devices.Add(new Light(name, location, brightness));
            Console.WriteLine("Light added.");
        }

        //method to add fan to the list
        public void AddFan()
        {
            Console.Write("Fan Name: ");
            string name = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("Speed (1-5): ");
            int speed = int.Parse(Console.ReadLine());

            //call object of fan call and add properties to list
            Devices.Add(new Fan(name, location, speed));
            Console.WriteLine("Fan added.");
        }

        //method to add ac to the list 
        public void AddAC()
        {
            Console.Write("AC Name: ");
            string name = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("Cooling Temperature: ");
            int temp = int.Parse(Console.ReadLine());

            Devices.Add(new AC(name, location, temp));
            Console.WriteLine("AC added.");
        }
        //method to turn on all devides at once
        public void TurnOnAll()
        {
            foreach (IControllable device in Devices)
            {
                device.TurnOn(); // polymorphism
            }
        }
        //method to turn of  all devices at once
        public void TurnOffAll()
        {
            foreach (IControllable device in Devices)
            {
                device.TurnOff(); // polymorphism
            }
        }

        //method to turn on a specific device
        public void TurnOnSpecific()
        {
            IControllable device = FindDevice();
            if (device != null)
                device.TurnOn();
        }

        //method to turn off a specific devices
        public void TurnOffSpecific()
        {
            IControllable device = FindDevice();
            if (device != null)
                device.TurnOff();
        }
        //helper function for turn on or off specific device
        //used to find the devices which we want to turn on or off
        private IControllable FindDevice()
        {
            Console.Write("Enter Appliance Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Location: ");
            string location = Console.ReadLine();

            foreach (IControllable device in Devices)
            {
                if (device is Appliance appliance)
                {
                    if (appliance.GetApplianceName() == name &&
                        appliance.GetLocation() == location)
                    {
                        return device;
                    }
                }
            }

            Console.WriteLine("Appliance not found.");
            return null;
        }
    }
}

    
