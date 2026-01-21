    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace BridgelabzTraining.senario_based.EduResult
    {
        internal interface IBoard
        {
            void AddDistrict(District d1);
            void MergeDistrict();
            void MergeSort();
            void AddDistrictStudents(int id, StudentMarks student);
            void DisplayTopTen();
        }
    }
