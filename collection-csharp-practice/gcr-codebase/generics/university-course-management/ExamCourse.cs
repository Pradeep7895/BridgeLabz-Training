using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.university_course_management
{
    internal class ExamCourse : CourseType
    {
        public int MaxMarks { get; protected set; }

        public ExamCourse(int courseId, string courseName, int maxMarks)
            : base(courseId, courseName)
        {
            MaxMarks = maxMarks;
        }

        public override void Evaluate()
        {
            Console.WriteLine(
                $"[Exam Course] {CourseId} - {CourseName}, Max Marks: {MaxMarks}");
        }
    }
}
