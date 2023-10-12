using Lesson11.Models;

namespace Lesson11
{
    internal class Program
    {
        static readonly Account account = Account.Deserialize();

        static void Main(string[] args)
        {
            ShowMenu();
            int selectedMenu = GetSelectedMenu();
            Console.Clear();
            ShowSelectedMenu(selectedMenu);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            Main(args);
        }

        static void ShowMenu()
        {
            Console.WriteLine("1. See All Transactions     2. Add Income     3. Add Expense");
            Console.WriteLine("4. Check Balance            5. Exit");
        }

        static int GetSelectedMenu()
        {
            Console.Write("Select menu: ");
            int input;

            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Select menu: ");
            }

            return input;
        }

        static void ShowSelectedMenu(int selectedMenu)
        {
            switch (selectedMenu)
            {
                case 1:
                    ShowAllTransactions();
                    break;
                case 2:
                    AddIncome();
                    break;
                case 3:
                    AddExpense();
                    break;
                case 4:
                    CheckBalance();
                    break;
                case 5:
                    CloseApplication();
                    break;
                default:
                    Console.WriteLine("Selected menu does not exist.");
                    break;
            }
        }

        static void ShowAllTransactions()
        {
            if (!account.GetTransactions().Any())
            {
                Console.WriteLine("No transactions to display.");
            }

            foreach (var transaction in account.GetTransactions())
            {
                if (transaction.Type == TransactionType.Income)
                {
                    DisplayIncome(transaction);
                }
                else
                {
                    DisplayExpense(transaction);
                }
            }

            Console.WriteLine("-----------");
            if (account.Balance < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine($"Your current balance: {account.Balance}");
            Console.ResetColor();
        }

        static void AddIncome()
        {
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Amount: ");
            decimal amount;

            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine();
                Console.Write("Please, enter a number.");
            }

            AddTransaction(description, amount, TransactionType.Income);
        }

        static void AddExpense()
        {
            Console.Write("Enter Description: ");
            string description = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter Amount: ");
            decimal amount;

            while (!decimal.TryParse(Console.ReadLine(), out amount))
            {
                Console.WriteLine();
                Console.Write("Please, enter a number.");
            }

            AddTransaction(description, amount, TransactionType.Expense);
        }

        static void CheckBalance()
        {
            Console.WriteLine($"Your current balance: {account.Balance}");
        }

        static void CloseApplication()
        {
            Console.WriteLine("Thanks for using Expense Tracker!");
            Environment.Exit(500);
        }

        static void AddTransaction(string description, decimal amount, TransactionType type)
        {
            Transaction newTransaction = new()
            {
                Description = description,
                Amount = amount,
                TransactionDate = DateTime.Now,
                Type = type
            };

            account.AddTransaction(newTransaction);
        }

        static void DisplayIncome(Transaction transaction)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(transaction.GetShortDetail());
            Console.ResetColor();
        }

        static void DisplayExpense(Transaction transaction)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(transaction.GetShortDetail());
            Console.ResetColor();
        }
    }
}