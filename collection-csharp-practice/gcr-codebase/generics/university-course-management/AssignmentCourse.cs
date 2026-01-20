using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.collection_csharp_practice.gcr_codebase.generics.university_course_management
{
    internal class AssignmentCourse : CourseType
    {
        public int AssignmentCount { get; protected set; }

        public AssignmentCourse(int courseId, string courseName, int assignmentCount)
            : base(courseId, courseName)
        {
            AssignmentCount = assignmentCount;
        }

        public override void Evaluate()
        {
            Console.WriteLine(
                $"[Assignment Course] {CourseId} - {CourseName}, Assignments: {AssignmentCount}");
        }
    
    }
}
