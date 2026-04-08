using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_number
{
    internal class AadharRecord
    {
        private string Name;
        private long Number;

        public AadharRecord(string name, long number)
        {
            Name = name;
            Number = number;
        }

        public string GetName() {  return Name; }
        public void SetName(string name) { Name = name; }
        public long GetNumber()
        {
            return Number;
        }
        public void SetNumber(long number)
        {
            Number = number;
        }
    }
}
