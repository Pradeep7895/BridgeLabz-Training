using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary
{
    internal class Eagle : Bird , IFlyable
    {
        //derived claas Eagle
        public Eagle(int birdID, string name, int age, string habitat, string diet, bool IsEndangered) 
            : base(birdID, name, age, habitat, diet, IsEndangered)
        {

        }

        //override fly method
        public void Fly()
        {
            Console.WriteLine("Eagle can fly very high.");

        }
        //ToString methof to override
        public override string ToString()
        {
            return base.ToString() +
                "Type : Eagle";
        }
    }
}
