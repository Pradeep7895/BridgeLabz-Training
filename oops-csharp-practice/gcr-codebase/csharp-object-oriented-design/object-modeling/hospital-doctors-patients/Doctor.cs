using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.hospital_doctors_patients
{
    internal class Doctor
    {
        public string Name { get; private set; }

        // Constructor to initialize doctor
        public Doctor(string name)
        {
            Name = name;
        }

        // Communication method between doctor and patient
        public void Consult(Patient patient)
        {
            Console.WriteLine($"Dr. {Name} is consulting {patient.Name}");
        }
    }
}
