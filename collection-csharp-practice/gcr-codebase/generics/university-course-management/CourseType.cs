using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.university_course_management
{
    internal abstract class CourseType
    {
        public int CourseId { get; protected set; }
        public string CourseName { get; protected set; }

        protected CourseType(int courseId, string courseName)
        {
            CourseId = courseId;
            CourseName = courseName;
        }

        public abstract void Evaluate();
    }
}
