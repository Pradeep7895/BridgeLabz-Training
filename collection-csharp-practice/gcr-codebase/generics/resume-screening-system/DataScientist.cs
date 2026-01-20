using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.resume_screening_system
{
    internal class DataScientist : JobRole
    {
        public int MLScore { get; protected set; }

        public DataScientist(int id, string name, int mlScore)
            : base(id, name)
        {
            MLScore = mlScore;
        }

        public override void EvaluateResume()
        {
            Console.WriteLine(
                $"[Data Scientist] {CandidateId} - {CandidateName}, ML Score: {MLScore}");
        }
    
    }
}
