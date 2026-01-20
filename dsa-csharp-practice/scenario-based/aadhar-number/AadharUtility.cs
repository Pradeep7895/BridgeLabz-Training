using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_number
{
    internal class AadharUtility
    {
        private AadharRecord[] records;
        private RadixSorting sorter = new RadixSorting();
        private Searching searcher = new Searching();

        public void AddAadharDetails()
        {
            Console.WriteLine("Enter number of entries of aadhar: ");
            int n = int.Parse(Console.ReadLine());

            records = new AadharRecord[n];

            for(int i=0; i<n; i++)
            {
                while (true)
                {
                    Console.WriteLine("Enter aadhar holder name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter 12 digit Aadhar number: ");
                    string number = Console.ReadLine();

                    if(number.Length == 12 && long.TryParse(number , out long num))
                    {
                        records[i] = new AadharRecord(name, num);
                        break;
                    }
                    Console.WriteLine("Invalid Aadhar.");
                }
            }
            Console.WriteLine("Aadhar Details Added sucessfully.");
        }

        public void SortAadharNum()
        {
            sorter.Sort(records);
            Console.WriteLine("Aadhar number sorted successfully.");
        }

        public void SearchAadhar()
        {
            Console.WriteLine("Enter Aadhar number : ");
            long target = long.Parse(Console.ReadLine());

            int index = searcher.Search(records, target);

            if(index != -1)
            {
                Console.WriteLine($"Aadhar found at position: " + ( index + 1));
            }
            else
            {
                Console.WriteLine("Aadhar not found");
            }
        }
        public void Display()
        {
            Console.WriteLine("Aadhar records : ");
            foreach (var item in records)
            {
                Console.WriteLine("Aadhar Holder Name : " + item.GetName() + " | " + "Aadhar Number :" + item.GetNumber());
            }
        }

    }
}
