using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson__1
{
    internal class Penalty
    {
        public string Date { get; set; }
        public string Location { get; set; }
        public string ViolationPoint { get; set; }
        public bool IsPaid { get; set; }
        public double Amount { get; set; }
        public int Id { get; set; }
        private static int id = 100;


        public Penalty(string date, string location, string violationPoint, double amount)
           
        {
            Id= id++;
            Date = date;
            Location = location;
            ViolationPoint = violationPoint;
            IsPaid = true;
            Amount = amount;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Jarima ID: {Id}\nJarima summasi: {Amount}\nQoidabuzarlik sanasi: {Date}\nQoidabuzarlik joyi: {Location}\nQpidabuzarlik moddasi: {ViolationPoint}\n");
            if (!IsPaid)
            {
                Console.WriteLine("Jarima xolati: To'langan");
            }
            else
            {
                Console.WriteLine("Jarima xolati: To'lanmagan");
            }
            Console.WriteLine();
        }
    }
}
