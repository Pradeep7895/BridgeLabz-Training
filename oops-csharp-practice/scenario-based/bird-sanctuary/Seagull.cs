using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary
{
    internal class Seagull : Bird, IFlyable , ISwimmable
    {
        //derived class Seagull
        public Seagull(int birdID, string name, int age, string habitat, string diet, bool IsEndangered)
          : base(birdID, name, age, habitat, diet, IsEndangered)
        {

        }
        //override fly methisd
        public void Fly()
        {
            Console.WriteLine("Seagull fly over sea with his powerful wings. ");
        }
        public void Swim()
        {
            Console.WriteLine("Seagull can swim with the help of their webbed feet.");

        }
        //ToString methof to override
        public override string ToString()
        {
            return base.ToString() +
                "Type : Seagull";
        }
    }
}
