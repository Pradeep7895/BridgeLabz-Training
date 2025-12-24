using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level1
{
    internal class EligibleForVote
    {
        static void Main(string[] args)
        {
            //Declare and initialize the array
            int[] age = new int[10];
            Console.WriteLine("Enter age of 10 students:");

            //Input the elements for array
            for (int i = 0; i < age.Length; i++)
            {
                Console.Write("Student " + (i + 1) + " age: ");
                age[i] = int.Parse(Console.ReadLine());
            }

            //Loop through the array to check voting eligibility
            for (int i = 0; i < age.Length; i++)
            {
                //check for invalid age
                if (age[i] < 0)
                {
                    Console.WriteLine("Invalid age.");
                }
                //check if student can vote
                else if (age[i] >= 18)
                {
                    Console.WriteLine("The student with the age " + age[i] + " can vote.");
                }
                //student cannot vote
                else
                {
                    Console.WriteLine("The student with the age " + age[i] + " cannot vote.");
                }
            }
        }
    }
}
