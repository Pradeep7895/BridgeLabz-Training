using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.insurance_policy_management
{
    internal class PolicyMenu
    {
        public void Start()
        {
            PolicyUtility utility = new PolicyUtility();
            int choice;

            do
            {
                Console.WriteLine("\n==== Insurance Policy Management ====");
                Console.WriteLine("1. Add Policy");
                Console.WriteLine("2. View All Policies");
                Console.WriteLine("3. View Policies Expiring Soon (30 days)");
                Console.WriteLine("4. View Policies by Coverage Type");
                Console.WriteLine("5. View Duplicate Policies");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        utility.AddPolicy();
                        break;

                    case 2:
                        utility.DisplayAllPolicies();
                        break;

                    case 3:
                        utility.PoliciesExpiringSoon();
                        break;

                    case 4:
                        utility.PoliciesByCoverage();
                        break;

                    case 5:
                        utility.ShowDuplicatePolicies();
                        break;

                    case 0:
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

            } while (choice != 0);
        }

    }
}

    