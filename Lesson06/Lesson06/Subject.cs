using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Hours { get; set; }

        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }

        public void DisplayStudents();
        public void DisplayTeachers();
    }
}
