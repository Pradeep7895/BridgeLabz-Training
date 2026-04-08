using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.parcel_tracker
{
    internal interface IParcel
    {
        void AddOrder();
        void AddStage();
        void AddIntermediateStage();
        void TrackParcel();
        void LostParcel();
    }
}
