using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.university_management_system
{
    internal class Professor
    {
        // Professor name
        public string Name { get; private set; }

        // Constructor to initialize professor
        public Professor(string name)
        {
            Name = name;
        }
    }
}
