using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Birthdate { get; set; }

        public Person() { }
    }
}
