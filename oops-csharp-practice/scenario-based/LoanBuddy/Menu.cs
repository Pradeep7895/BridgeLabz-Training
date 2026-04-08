using BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.LoanBuddy
{
    internal class Menu
    {
        private ApplicantUtility Utility = new ApplicantUtility();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\nLoanBuddy Menu : ");
                Console.WriteLine("1. Apply Home Loan");
                Console.WriteLine("2. Apply Auto Loan");
                Console.WriteLine("3. Apply Personal Loan");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                    continue;

                if (choice == 0)
                    return;

                // Step 1: Get applicant details
                Applicant applicant = Utility.CreateApplicant();

                // Step 2: Get loan term
                int term;
                while (true)
                {
                    Console.Write("Loan Term (months): ");
                    if (int.TryParse(Console.ReadLine(), out term))
                        break;
                    Console.WriteLine("Invalid term. Try again.");
                }

                // Step 3: Create loan object using polymorphism
                IApprovable loan = null;

                switch (choice)
                {
                    case 1:
                        loan = new HomeLoan(applicant, term);
                        break;
                    case 2:
                        loan = new AutoLoan(applicant, term);
                        break;
                    case 3:
                        loan = new PersonalLoan(applicant, term);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        continue;
                }

                // Step 4: Approve loan and calculate EMI
                if (loan.ApproveLoan())
                {
                    Console.WriteLine("Loan Approved");
                    Console.WriteLine("Monthly EMI: " + loan.CalculateEMI());
                }
                else
                {
                    Console.WriteLine("Loan Rejected");
                }
            }
        }

    }
}

    