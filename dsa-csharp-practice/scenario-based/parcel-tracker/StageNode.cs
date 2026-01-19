using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.parcel_tracker
{
    internal class StageNode
    {
        public string StageName;
        public StageNode Next;

        public StageNode(string stageName)
        {
            StageName = stageName;
            Next = null;
        }
    }
}
