using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level01
{
    internal class Person
    {
        private string name;
        private int age;

        //parameterized cons.
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //copy cons.
        public Person(Person other)
        {
            this.name = other.name;
            this.age = other.age;

        }
        //method to display details
        public void Display()
        {
            
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }

        public static void Main(string[] args)
        {
            //using parameterized cons.
            Person p1 = new Person("Pradeep", 22);

            Console.WriteLine("Original: ");
            p1.Display();

            //using copy cons.
            Person p2 = new Person(p1);

            Console.WriteLine("\nCopy: ");
            p2.Display();

        }
    }
}
