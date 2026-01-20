using BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_number
{
    internal class Searching
    {
        public int Search(AadharRecord[] records, long target)
        {
            int left = 0, right = records.Length - 1;
            while(left <= right)
            {
                int mid = left + (right - left) / 2;
                if (records[mid].GetNumber() == target)
                    return mid;
                else if (records[mid].GetNumber() < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
