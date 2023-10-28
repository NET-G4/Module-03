using Lesson10.Exceptions;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Lesson10.Models
{
    internal class Cart
    {
        public decimal TotalPrice { get; set; }
        public decimal TotalPriceDiscount { get; set; }

        [JsonInclude]
        public readonly List<CartItem> items;

        public Cart() 
        {
            items = new List<CartItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            ArgumentNullException.ThrowIfNull(product);

            foreach(var item in items)
            {
                if (item.Product.Id == product.Id)
                {
                    item.Quantity += quantity;
                    return;
                }
            }

            items.Add(new CartItem()
            {
                Product = product,
                Quantity = quantity,
            });
        }
    }
}
