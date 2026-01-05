using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_with_faculty_and_depart
{
    // Faculty members can exist independently
    internal class Faculty
    {
        public string Name { get; private set; }

        // Constructor to initialize faculty
        public Faculty(string name)
        {
            Name = name;
        }
    }
}
