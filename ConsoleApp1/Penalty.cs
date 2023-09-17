using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Penalty
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string DateTime { get; set; }
        public bool Dontpaid { get; set; }

        private static int id = 1000;

        public Penalty(string description,string dateTime, decimal amount)
        {
            Id = id++;
            Description = description;
            DateTime = dateTime;
            Amount = amount;
            Dontpaid = true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}\nAmount: {Amount}\nDate time: {DateTime}\nDescription: {Description}\n\n");
            if(!Dontpaid)
            {
                Console.WriteLine("Jarima xolati: To'langan");
            } else
            {
                Console.WriteLine("Jarima xolati: To'lanmagan");
            }
            Console.WriteLine("\n");
        }
    }
}
