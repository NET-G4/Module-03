using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class Enrollment
    {
        public Subject Subject { get; set; }
        public Teacher Teacher { get; private set; }
        public List<Student> Students { get; private set; }

        public Enrollment(Subject subject, Teacher teacher)
        {
            Subject = subject;
            Teacher = teacher;
            Students = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            if (Students.Contains(student))
            {
                throw new Exception("Student already enrolled");
            }

            try
            {
                Students.Add(student);
                student.Enroll(this);
            }
            catch(Exception ex)
            {
                Students.Remove(student);
                throw;
            }
        }
    }
}
