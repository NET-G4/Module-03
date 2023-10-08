using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.Models
{
    internal class CartItem
    {
        public int Id { get; set; }
        private int _quantity;
        public int Quantity 
        {
            get => _quantity;
            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    TotalPrice = Product.Price * value;
                    TotalPriceDiscount = Product.PriceDiscount * value;
                }
            }
        } // 5
        public decimal TotalPrice { get; set; } 
        public decimal TotalPriceDiscount { get; set; }

        public Product Product { get; set; } // 500, 400
    }
}
