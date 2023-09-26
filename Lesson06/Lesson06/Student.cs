using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class Student : Person
    {
        public string StudentNumber { get; set; }
        public List<Enrollment> Enrollments { get; private set; }

        public Student(string studentNumber)
        {
            StudentNumber = studentNumber;
            Enrollments = new List<Enrollment>();
        }

        public void Enroll(Enrollment subjectEnrollment)
        {
            if (Enrollments.Contains(subjectEnrollment))
            {
                throw new Exception("Student already enrolled");
            }

            Enrollments.Add(subjectEnrollment);
            subjectEnrollment.EnrollStudent(this);
        }

        public List<Subject> GetSubjects()
        {
            List<Subject> subjects = new List<Subject>();

            foreach(var enrollment in Enrollments)
            {
                if (!subjects.Contains(enrollment.Subject))
                {
                    subjects.Add(enrollment.Subject);
                }
            }

            return subjects;
        }
    }
}
