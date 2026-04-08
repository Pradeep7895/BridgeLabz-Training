using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.freelancers_invoice
{
    internal class MainProgram
    {
        static void Main()
        {
            string input = "Logo Design - 3000 INR, Web Page - 4500 INR, Content Writing - 2500 INR";

            // Parse invoice
            string[] tasks = Invoice.GetInvoice(input);

            Console.WriteLine("Invoice Details:");
            foreach (string task in tasks)
            {
                Console.WriteLine(task.Trim());
            }

            // Calculate total
            int total = Invoice.GetTotal(tasks);

            Console.WriteLine("\nTotal Invoice Amount: " + total + " INR");
        }

    }
}

        