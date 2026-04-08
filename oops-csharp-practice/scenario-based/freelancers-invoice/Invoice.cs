using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.freelancers_invoice
{
    internal class Invoice
    {
        // Method for invoice input 
        public static string[] GetInvoice(string input)
        {
            // Split by comma to get each task
            string[] tasks = input.Split(',');

            return tasks;
        }

        // Method to calculate total invoice amount
        public static int GetTotal(string[] tasks)
        {
            int totalAmount = 0;

            foreach (string task in tasks)
            {
                // Split by hyphen to separate task name and amount
                string[] parts = task.Split('-');

                if (parts.Length == 2)
                {
                    // Extract amount and remove "INR"
                    string amountPart = parts[1].Replace("INR", "").Trim();

                    int amount = int.Parse(amountPart);
                    totalAmount += amount;
                }
            }

            return totalAmount;
        }
    }
}

    
        
