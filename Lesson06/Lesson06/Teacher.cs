using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Enrollment> Enrollments { get; set; }

        public void Enroll(Enrollment subjectEnrollment)
        {
            if (Enrollments.Contains(subjectEnrollment))
            {
                throw new Exception("Teacher already enrolled.");
            }

            Enrollments.Add(subjectEnrollment);
        }

        // Display students studying under this teacher
        // public void ShowStudent()
        // Display subjects taught by this teacher
        //public void ShowSubject()
    }
}
