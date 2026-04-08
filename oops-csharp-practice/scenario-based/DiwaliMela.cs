using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class DiwaliMela
    {
        static void Main()
        {
            Console.WriteLine("Diwali Festival Lucky Draw");
            StartLuckyDraw();
        }

        // Method to start the lucky draw
        static void StartLuckyDraw()
        {
            while (true)
            {
                // Prompt user for input
                Console.Write("Enter a lucky number (or type -1 to stop): ");
                string input = Console.ReadLine();

                if (input == "-1")
                {
                    Console.WriteLine("Lucky Draw Closed.");
                    break;
                }

                // Validate input
                if (!IsValidNumber(input, out int num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                CheckWinner(num);
            }
        }

        // Method to validate number input
        static bool IsValidNumber(string input, out int number)
        {
            return int.TryParse(input, out number);
        }

        // Method to check winning condition
        static void CheckWinner(int num)
        {
            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Congratulations! You won a gift!");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }
        }


    }
}


   