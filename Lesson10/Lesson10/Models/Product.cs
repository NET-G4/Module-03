using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal PriceDiscount { get; set; }

        public override string ToString()
        {
            return $"Id {Id}, Name {Name}, Price {Price}, Discount {Discount}";
        }
    }
}
