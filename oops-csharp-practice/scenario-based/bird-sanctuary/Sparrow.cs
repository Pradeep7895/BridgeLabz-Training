using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary
{
    internal class Sparrow : Bird , IFlyable
    {
        //derived class Sparrow
        public Sparrow(int birdID, string name, int age, string habitat, string diet, bool IsEndangered)
           : base(birdID, name, age, habitat, diet, IsEndangered)
        {

        }
        //override   fly method
        public void Fly()
        {
            Console.WriteLine("Sparrows fly small distances.");

        }
        //ToString methof to override
        public override string ToString()
        {
            return base.ToString() +
                "Type : Sparrow";
        }
    }
}
