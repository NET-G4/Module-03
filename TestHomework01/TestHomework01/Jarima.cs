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
        public string Palace { get; set; }
        public bool IsPaid { get; set; }

        public Jarima(decimal value, DateTime date, string palace, bool isPaid)
        {
            ID=++id;
            this.value=value;
            Date=date;
            Palace=palace;
            IsPaid=isPaid;
        }
    }
}
