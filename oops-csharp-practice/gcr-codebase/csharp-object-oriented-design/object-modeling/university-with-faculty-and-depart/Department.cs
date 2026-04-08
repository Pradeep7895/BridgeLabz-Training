using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_with_faculty_and_depart
{
    // Department is owned by University (composition)
    internal class Department
    {
        public string Name { get; private set; }

        // This is aggregation because faculty can exist independently
        private List<Faculty> faculties;

        public Department(string name)
        {
            Name = name;
            faculties = new List<Faculty>();
        }

        // Add faculty to department
        public void AddFaculty(Faculty faculty)
        {
            faculties.Add(faculty);
        }
    }
}
