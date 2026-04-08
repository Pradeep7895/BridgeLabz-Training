using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.insurance_policy_management
{
    internal class PolicyUtility
    {
        private HashSet<Policy> policySet = new HashSet<Policy>();
        private List<Policy> insertionOrder = new List<Policy>();
        private SortedSet<Policy> sortedByExpiry = new SortedSet<Policy>();
        private Dictionary<string, int> policyCount = new Dictionary<string, int>();

        public void AddPolicy()
        {
            Policy policy = new Policy();

            Console.Write("Enter Policy Number: ");
            policy.PolicyNumber = Console.ReadLine();

            Console.Write("Enter Holder Name: ");
            policy.HolderName = Console.ReadLine();

            Console.Write("Enter Coverage Type: ");
            policy.CoverageType = Console.ReadLine();

            Console.Write("Enter Expiry Date (yyyy-mm-dd): ");
            policy.ExpiryDate = DateTime.Parse(Console.ReadLine());

            if (policyCount.ContainsKey(policy.PolicyNumber))
                policyCount[policy.PolicyNumber]++;
            else
                policyCount[policy.PolicyNumber] = 1;

            if (policySet.Add(policy))
            {
                insertionOrder.Add(policy);
                sortedByExpiry.Add(policy);
                Console.WriteLine("Policy added successfully.");
            }
            else
            {
                Console.WriteLine("Duplicate policy detected (same policy number).");
            }
        }

        public void DisplayAllPolicies()
        {
            Console.WriteLine("\nAll Unique Policies:");
            foreach (var p in insertionOrder)
                Print(p);
        }

        public void PoliciesExpiringSoon()
        {
            Console.WriteLine("\nPolicies Expiring in Next 30 Days:");
            DateTime limit = DateTime.Now.AddDays(30);

            foreach (var p in sortedByExpiry)
            {
                if (p.ExpiryDate <= limit)
                    Print(p);
            }
        }

        public void PoliciesByCoverage()
        {
            Console.Write("Enter Coverage Type: ");
            string coverage = Console.ReadLine();

            Console.WriteLine("\nMatching Policies:");
            foreach (var p in policySet)
            {
                if (p.CoverageType.Equals(coverage, StringComparison.OrdinalIgnoreCase))
                    Print(p);
            }
        }

        public void ShowDuplicatePolicies()
        {
            Console.WriteLine("\nDuplicate Policies:");
            foreach (var item in policyCount)
            {
                if (item.Value > 1)
                    Console.WriteLine("Policy Number: " + item.Key);
            }
        }

        private void Print(Policy p)
        {
            Console.WriteLine($"{p.PolicyNumber} | {p.HolderName} | {p.CoverageType} | {p.ExpiryDate.ToShortDateString()}");
        }

    }
}

    