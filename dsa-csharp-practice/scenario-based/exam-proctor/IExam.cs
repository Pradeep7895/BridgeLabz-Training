using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_proctor
{
    internal interface IExam
    {
        void AddStudent();
        void VisitQuestion();
        void AnswerQuestion();
        void GoBack();
        void SubmitExam();
    }
}

