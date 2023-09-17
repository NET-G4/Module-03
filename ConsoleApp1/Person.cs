using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public static Dictionary<int, Person> Persons = new Dictionary<int, Person>();
        public int Id { get; set; }
        public string Name { get; set; }

        private static int id = 1000000;

        public Queue<Penalty> Penaltys = new Queue<Penalty>();

        public Stack<Penalty> Payouts = new Stack<Penalty>();

        public Person(string name)
        {
            Id = id++;
            Name = name;
            Persons.Add(Id, this);
        }

        public void AddPenalty(Penalty penalty)
        {
            Penaltys.Enqueue(penalty);
        }

        public void AddPayout(Penalty penalty)
        {
            penalty.Dontpaid = false;
            Payouts.Push(penalty);
        }

        public void DisplayPenaltys()
        {
            for(int i = 0; i < Penaltys.Count; i++)
            {
                Penaltys.Dequeue().DisplayInfo();
            }
        }

        public void DisplayPayouts()
        {
            for (int i = 0; i < Payouts.Count; i++)
            {
                Payouts.Pop().DisplayInfo();
            }
        }
    }
}
