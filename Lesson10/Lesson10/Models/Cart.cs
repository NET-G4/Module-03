using Lesson10.Exceptions;

namespace Lesson10.Models
{
    internal class Cart
    {
        public decimal TotalPrice { get; set; }
        public decimal TotalPriceDiscount { get; set; }

        private readonly List<CartItem> items;

        public Cart() 
        {
            items = new List<CartItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            if (product == null)
            {
                throw new CartItemCannotBeNullException();
            }

            foreach(var item in items)
            {
                if (item.Product.Id == product.Id)
                {
                    item.Quantity = item.Quantity + quantity;
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
