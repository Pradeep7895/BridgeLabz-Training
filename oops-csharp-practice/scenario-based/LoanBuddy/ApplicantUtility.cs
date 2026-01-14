using BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class ApplicantUtility
    {
        public Applicant CreateApplicant()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            int creditScore;
            while (true)
            {
                Console.Write("Credit Score: ");
                if (int.TryParse(Console.ReadLine(), out creditScore))
                    break;
                Console.WriteLine("Invalid credit score. Try again.");
            }

            double income;
            while (true)
            {
                Console.Write("Monthly Income: ");
                if (double.TryParse(Console.ReadLine(), out income))
                    break;
                Console.WriteLine("Invalid income. Try again.");
            }

            double loanAmount;
            while (true)
            {
                Console.Write("Loan Amount: ");
                if (double.TryParse(Console.ReadLine(), out loanAmount))
                    break;
                Console.WriteLine("Invalid loan amount. Try again.");
            }

            return new Applicant(name, creditScore, income, loanAmount);
        }

    }
}

   
