using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system
{
    internal abstract class JobRole
    {
        public int CandidateId { get; protected set; }
        public string CandidateName { get; protected set; }

        protected JobRole(int candidateId, string candidateName)
        {
            CandidateId = candidateId;
            CandidateName = candidateName;
        }

        public abstract void EvaluateResume();
    }
}
