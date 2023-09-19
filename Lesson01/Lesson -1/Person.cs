using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__1
{
    internal class Person
    {
        public static Dictionary<int, Person> persons = new Dictionary<int, Person>();
        public string FullName { get; set; }
        public string Birthday { get; set; }

        private static int id = 1000000;

        public Queue<Penalty> penaltiys = new Queue<Penalty>();
        public Stack<Penalty> payment = new Stack<Penalty>();
        static Person()
        {
            Console.WriteLine("\t\tAssalomu alaykum |-Road24-| ilovasiga hush kelibsiz:\n");
        }
        public Person(string fullName, string birthday)
        {
            id = id++;
            FullName = fullName;
            Birthday = birthday;
           persons.Add(id, this);
        }

        public void AddPenalty(Penalty penalty)
        {
            penaltiys.Enqueue(penalty);
        }
        public void AddPayment(Penalty penalty)
        {
            penalty.IsPaid = false;
            payment.Push(penalty);
        }
        public void DisplayPenaltys()
        {
            for (int i = 0; i < penaltiys.Count; i++)
            {
                penaltiys.Dequeue().DisplayInfo();
            }
        }
        public void DisplayPayment()
        {
            for (int i = 0; i < payment.Count; i++)
            {
                payment.Pop(); DisplayPenaltys();
            }
        }
        public void DisplayInfoPerson( )
        {
            Console.WriteLine($"Fuqoroning F.I.Sh.: {FullName}\nTug'ilgan yili: {Birthday}");
        }
    }
}
