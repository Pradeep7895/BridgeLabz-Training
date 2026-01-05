using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_object_oriented_design.object_modeling.hospital_doctors_patients
{
    internal class Program
    {
        static void Main()
        {
            // Create doctor objects
            Doctor d1 = new Doctor("Singh");
            Doctor d2 = new Doctor("Verma");

            // Create patient objects
            Patient p1 = new Patient("Rahul");
            Patient p2 = new Patient("Anita");

            // Doctors consulting patients
            d1.Consult(p1);
            d1.Consult(p2);
            d2.Consult(p1);
        }
    }
}
