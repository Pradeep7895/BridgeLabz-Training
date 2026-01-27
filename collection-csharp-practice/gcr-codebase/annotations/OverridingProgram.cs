using System;

namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class OverridingProgram
    {
        static void Main()
        {
            Animal animal = new Dog();
            animal.MakeSound();
        }
    }
}
