using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_with_faculty_and_depart
{
    // University owns departments (composition)
    internal class University
    {
        public string Name { get; private set; }

        // Departments belong to university
        private List<Department> departments;

        // Constructor to initialize university
        public University(string name)
        {
            Name = name;
            departments = new List<Department>();
        }

        // University creates departments
        public void AddDepartment(string deptName)
        {
            departments.Add(new Department(deptName));
        }
    }
}
