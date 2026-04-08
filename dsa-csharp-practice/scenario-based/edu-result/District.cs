using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.EduResult
{
    internal class District
    {
        public int districtId ;
        public List<StudentMarks> districtStudents = new List<StudentMarks>();

        public District(int id, List<StudentMarks> s)
        {
            this.districtId = id;
            this.districtStudents = s;
        }
        public void Sort()
        {
            districtStudents.Sort((a, b) => b.GetMarks().CompareTo(a.GetMarks()));
        }

        public void Display()
        {
            foreach(StudentMarks i in districtStudents)
            {
                Console.WriteLine(i);
            }
        }
    }
}
