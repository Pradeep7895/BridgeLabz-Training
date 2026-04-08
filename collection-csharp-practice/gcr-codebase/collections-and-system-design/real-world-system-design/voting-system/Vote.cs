using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.collections_and_system_design.real_world_system_design.voting_system
{
    internal class Vote
    {
        public string CandidateName;

        public Vote(string candidateName)
        {
            CandidateName = candidateName;
        }

        public string GetCandidateName() {  return CandidateName; }

        public void SetCandidateName(string candidateName) { CandidateName = candidateName; }
    }
}
