using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.company_and_departments
{
    internal class Program
    {
        static void Main()
        {
            // Create company
            Company company = new Company("Tech Solutions");

            // Company creates departments
            company.AddDepartment("IT");
            company.AddDepartment("HR");

            // Departments create employees
            company.GetDepartment("IT").AddEmployee("Rahul");
            company.GetDepartment("IT").AddEmployee("Anita");
            company.GetDepartment("HR").AddEmployee("Suresh");

            // Display everything
            company.ShowCompanyDetails();

            // Deleting company removes departments and employees
            company = null;
        }
    }
}
