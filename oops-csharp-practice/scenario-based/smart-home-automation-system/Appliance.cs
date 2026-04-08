using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class Appliance
    {
        //instance member
        private string ApplianceName;
        private string Location;
        private bool IsOn;

        //constructor
        public Appliance(string applianceName, string location)
        {
            ApplianceName = applianceName;
            Location = location;
            IsOn = true;
        }
        //getter and setter methods
        //for appliance name
        public string GetApplianceName() { return ApplianceName; }
        public void SetApplianceName(string applianceName) { ApplianceName = applianceName; }

        //for location of the appliance
        public string GetLocation() { return Location; }
        public void SetLocation(string location) { Location = location; }

        //for status 
        protected bool GetStatus() { return IsOn; }
        protected void SetStatus(bool status) { IsOn = status; }
        
       
    }
}
