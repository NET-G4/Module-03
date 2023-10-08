using Lesson10.Models;

namespace Lesson10.Services
{
    internal class ProductsService
    {
        private readonly Dictionary<int, Product> products;

        public ProductsService()
        {
            products = new Dictionary<int, Product>();
            LoadProducts();
        }

        private void LoadProducts()
        {
            products.Add(1, new Product()
            {
                Id = 1,
                Name = "Coca-Cola",
                Description = "Coca-cola shakarsiz",
                Price = 5000,
                Discount = 500,
                PriceDiscount = 4500
            });
        }

        public void ShowAllProducts()
        {
            foreach(var item in products)
            {
                Console.WriteLine(item);
            }
        }

        public Product? GetProductById(int id)
        {
            if (products.TryGetValue(id, out var product)) 
                return product;

            return null;
        }
    }
}
