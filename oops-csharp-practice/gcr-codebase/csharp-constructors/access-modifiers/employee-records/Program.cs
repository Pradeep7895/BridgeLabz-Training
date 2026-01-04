using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.access_modifiers.employee_records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(1, "IT", 75000, 10);

            manager.DisplayDetails();

            Console.WriteLine("\nUpdating Salary...");
            manager.SetSalary(85000);

            Console.WriteLine();

            manager.DisplayDetails();
        }
    }
}
