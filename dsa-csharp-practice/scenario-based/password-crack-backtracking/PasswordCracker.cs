using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based
{
    internal class PasswordCracker
    {
        private static bool found = false;
        private static int attempts = 0;

        // Backtracking function
        static void CrackPassword(string current, int length, char[] charset, string password)
        {
            // Stop further recursion once found
            if (found)
                return;

            // If required length reached
            if (current.Length == length)
            {
                attempts++;
                Console.WriteLine("Trying: " + current);

                if (current.Equals(password))
                {
                    Console.WriteLine("\n✅ Password FOUND: " + current);
                    Console.WriteLine("Attempts taken: " + attempts);
                    found = true;
                }
                return;
            }

            // Try all characters (choice)
            foreach (char c in charset)
            {
                CrackPassword(current + c, length, charset, password);
            }
        }
        static void Main()
        {
            Console.Write("Enter character set (e.g. abc or 0123): ");
            string charInput = Console.ReadLine();

            Console.Write("Enter password to crack: ");
            string password = Console.ReadLine();

            char[] charset = charInput.ToCharArray();
            int length = password.Length;

            Console.WriteLine("\n--- Starting Password Cracking ---\n");

            CrackPassword("", length, charset, password);

            if (!found)
            {
                Console.WriteLine("\n❌ Password not found.");
                Console.WriteLine("Total attempts: " + attempts);
            }
        }

    }
}

   
    
