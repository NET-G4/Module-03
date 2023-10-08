using Lesson10.Models;
using Lesson10.Services;
using System.Text.Json;

namespace Lesson10
{
    internal class Program
    {
        private static ProductsService productsService;
        private static Cart cart;
        static void Main(string[] args)
        {
            productsService = new ProductsService();

            ShowMenu();

            Main(args);
        }

        static void LoadData()
        {
            // Load cart from previous session
        }

        static void ShowMenu()
        {
            Console.WriteLine("Select Menu.");
            Console.WriteLine("1. See Products    2. Check Cart    3. Make Order    4. Exit");
            int selectedMenu = GetMenuOption();

            switch(selectedMenu)
            {
                case 1:
                    ShowProducts();
                    break;
                case 2:
                    CheckoutCart();
                    break;
                case 3:
                    MakeOrder();
                    break;
                case 4:
                    CloseApplication();
                    break;
                default:
                    Console.WriteLine("Please, select valid menu option.");
                    break;
            }
        }

        static int GetMenuOption()
        {
            string input = Console.ReadLine();
            int result;

            while(!int.TryParse(input, out result))
            {
                Console.WriteLine("Please, enter a number");
                input = Console.ReadLine();
            }

            return result;
        }

        static void ShowProducts()
        {
            try
            {
                productsService.ShowAllProducts();

                Console.WriteLine("Enter product id to add to cart or 0 to go back");

                int input = int.Parse(Console.ReadLine());

                if (input == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Enter quantity");
                    int quantity = int.Parse(Console.ReadLine());

                    var product = productsService.GetProductById(input);

                    cart.AddItem(product, quantity);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an error displaying products.");
                Console.WriteLine(ex.Message);
            }
        }

        static void MakeOrder()
        {

        }

        static void CheckoutCart()
        {

        }

        static void CloseApplication()
        {
            Environment.Exit(500);
        }
    }
}