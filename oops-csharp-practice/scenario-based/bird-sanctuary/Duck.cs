using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary
{
    internal class Duck : Bird , ISwimmable
    {
        //derived class
        public Duck(int birdID, string name, int age, string habitat, string diet, bool IsEndangered)
           : base( birdID, name, age, habitat, diet,IsEndangered )
        {

        }
        //override swim methid
        public void Swim()
        {
            Console.WriteLine("Ducks can swim in water too.");

        }
        //ToString methof to override
        public override string ToString()
        {
            return base.ToString() +
                "Type : Duck";
        }
    }
}
