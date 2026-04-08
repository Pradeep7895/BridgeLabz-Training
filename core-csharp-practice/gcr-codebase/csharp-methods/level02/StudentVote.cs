using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.methods.level02
{
    internal class StudentVote
    {

        // Method to check voting eligibility
        public static bool CanStudentVote(int age)
        {
            // Invalid age check
            if (age < 0)
                return false;

            // Voting age check
            return age >= 18;
        }
        static void Main()
        {
            // Array to store ages of 10 students
            int[] ages = new int[10];

            // Loop through students
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine()!);

                // Display result
                Console.WriteLine(CanStudentVote(ages[i])
                    ? "Can Vote"
                    : "Cannot Vote");
            }
        }
    }
}
