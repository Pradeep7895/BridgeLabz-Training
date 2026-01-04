using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    internal class Animal
    {
        // Attributes
        public string Name;
        public int Age;

        // Method
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    // Subclass Dog
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    // Subclass Cat
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows");
        }
    }
    // Subclass Bird
    class Bird : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bird chirps");
        }
    }
    class Program
    {
        static void Main()
        {
            // Polymorphism: base class reference
            Animal a1 = new Dog();
            Animal a2 = new Cat();
            Animal a3 = new Bird();

            a1.MakeSound();
            a2.MakeSound();
            a3.MakeSound();
        }
    }
}
