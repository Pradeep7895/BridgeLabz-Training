using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary
{
    internal class Program
    {
        static void Main()
        {
            //array
            Bird[] birds = new Bird[5];

            birds[0] = new Eagle(1, "Eagle Queen", 5, "Mountains", "Carnivore", true);
            birds[1] = new Sparrow(2, "Sparrow Queen", 4, "Urban", "Omnivore", false);
            birds[2] = new Duck(3, "Donald Duck", 2, "Wetland", "Omnivore", false);
            birds[3] = new Penguin(4, "Penguin Smart", 18, "Polar", "Carnivore", true);
            birds[4] = new Seagull(5, "Seagull Hunter", 5, "Coastal", "Omnivore", false);

            Console.WriteLine("Bird Sanctuary Report: ");

            for(int i = 0; i < birds.Length; i++)
            {
                //display details 
                Console.WriteLine(birds[i]);

                //for birds who can fly
                if (birds[i] is IFlyable f)
                {
                    f.Fly();
                }
                //for birds who can swim
                if (birds[i] is ISwimmable s)
                {
                    s.Swim();
                }
                Console.WriteLine();
            }
        }
    }
}
