using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.encapsulation_polymorphism_interface_abstractclass.hospital_patient_management
{
    internal interface IMedicalRecord
    {
        // Interface for medical record management
        void AddRecord(string record);
        void ViewRecords();
    }
}


