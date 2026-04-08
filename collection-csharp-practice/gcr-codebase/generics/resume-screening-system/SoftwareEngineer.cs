using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system
{
    internal class SoftwareEngineer : JobRole
    {
        public int CodingScore { get; protected set; }

        public SoftwareEngineer(int id, string name, int codingScore)
            : base(id, name)
        {
            CodingScore = codingScore;
        }

        public override void EvaluateResume()
        {
            Console.WriteLine(
                $"[Software Engineer] {CandidateId} - {CandidateName}, Coding Score: {CodingScore}");
        }
    
    }
}
