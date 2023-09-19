using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHomework01
{
    internal class Jarima
    {
        static private int id = 0;
        public int ID { get;private set; }
        public decimal value { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public bool IsPaid { get; set; } = false;

        public Jarima(decimal value, DateTime date, string reason)
        {
            ID = ++id;
            this.value = value;
            Date = date;
            Reason = reason;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("****************");
            Console.WriteLine($"Jarima ID : {ID}");
            Console.WriteLine($"Qiymati : {value}");
            Console.WriteLine($"Vaqti {Date}");
            Console.WriteLine($"Sababi : {Reason}");
            Console.WriteLine($"To'langan {IsPaid}");
            Console.WriteLine("****************");
        }
    }
}
