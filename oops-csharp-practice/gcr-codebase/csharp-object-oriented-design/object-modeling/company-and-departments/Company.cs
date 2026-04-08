using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.company_and_departments
{
    internal class Company
    {
        // Company name
        public string CompanyName { get; private set; }

        // Departments belong to company
        private List<Department> departments;

        // Company creates departments
        public Company(string companyName)
        {
            CompanyName = companyName;
            departments = new List<Department>();
        }

        // Add a new department to company
        public void AddDepartment(string departmentName)
        {
            departments.Add(new Department(departmentName));
        }
        // Get department by name
        public Department GetDepartment(string departmentName)
        {
            return departments.Find(d => d.DepartmentName == departmentName);
        }

        // Show complete company details
        public void ShowCompanyDetails()
        {
            Console.WriteLine($"Company: {CompanyName}");
            foreach (Department dept in departments)
                dept.ShowEmployees();
        }
    }
}
