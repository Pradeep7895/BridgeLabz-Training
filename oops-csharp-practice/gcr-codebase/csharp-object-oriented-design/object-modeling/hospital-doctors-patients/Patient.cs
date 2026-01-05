using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.hospital_doctors_patients
{
    internal class Patient
    {
        // Patient name
        public string Name { get; private set; }

        // Constructor to initialize patient
        public Patient(string name)
        {
            Name = name;
        }
    }
}
