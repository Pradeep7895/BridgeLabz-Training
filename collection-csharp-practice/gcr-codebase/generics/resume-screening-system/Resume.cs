using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system
{
    internal class Resume<T> where T : JobRole
    {
        private List<T> candidates = new List<T>();

        public void AddCandidate(T candidate)
        {
            candidates.Add(candidate);
            Console.WriteLine("Resume added to screening pipeline.");
        }

        // Variance-friendly
        public IEnumerable<T> GetCandidates()
        {
            return candidates;
        }
    }

}
