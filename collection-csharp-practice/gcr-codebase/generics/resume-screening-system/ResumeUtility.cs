using Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system
{
    internal class ResumeUtility
    {
        private Resume<SoftwareEngineer> softwareEngineers = new();
        private Resume<DataScientist> dataScientists = new();

        //Generic METHOD with constraint
        public void ProcessResume<T>(Resume<T> resumeStore, T candidate)
            where T : JobRole
        {
            resumeStore.AddCandidate(candidate);
        }

        //ONE display method 
        public void DisplayResumes(IEnumerable<JobRole> candidates)
        {
            bool found = false;

            foreach (JobRole candidate in candidates)
            {
                candidate.EvaluateResume(); // polymorphism
                found = true;
            }

            if (!found)
            {
                Console.WriteLine("No resumes available.");
            }
        }

        // Accessors only
        public Resume<SoftwareEngineer> GetSoftwareEngineers() { return softwareEngineers; }
        public Resume<DataScientist> GetDataScientists() { return dataScientists; }
    }
}


    