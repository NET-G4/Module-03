using Newtonsoft.Json;

namespace Lesson11.Models
{
    [Serializable]
    internal class Account
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; private set; }

        private List<Transaction> Transactions { get; set; }

        public Account(int id, string owner)
        {
            Id = id;
            Owner = owner;

            Transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            if (transaction.Type == TransactionType.Income)
            {
                Balance += transaction.Amount;
            }
            else
            {
                Balance -= transaction.Amount;
            }

            Transactions.Add(transaction);

            Serialize();
        }

        private void Serialize()
        {
            try
            {
                SaveAccountDetails();
                SaveTransactionDetails();
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Account Deserialize()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\files";
            string file = path + "\\account.json";

            using FileStream fs = new(file, FileMode.OpenOrCreate);
            using StreamReader reader = new(fs);

            string json = reader.ReadToEnd();

            Account account = JsonConvert.DeserializeObject<Account>(json) ?? new Account(1, "No name");
            account.Transactions = DeserializeTransactions();
            account.Balance = account.Transactions.Sum(CalculateSum);

            return account;
        }

        private static decimal CalculateSum(Transaction transaction) => transaction.Amount;

        private static List<Transaction> DeserializeTransactions()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\files";
            string file = path + "\\transactions.json";

            using FileStream fs = new(file, FileMode.OpenOrCreate);
            using StreamReader reader = new(fs);

            string json = reader.ReadToEnd();
            List<Transaction> transactions = JsonConvert.DeserializeObject<List<Transaction>>(json) ?? new List<Transaction>();

            return transactions;
        }

        private void SaveAccountDetails()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\files";
            string file = path + "\\account.json";

            Directory.CreateDirectory(path);

            using FileStream fs = new(file, FileMode.OpenOrCreate);
            using StreamWriter writer = new(fs);

            string json = JsonConvert.SerializeObject(this);
            writer.Write(json);
        }

        private void SaveTransactionDetails()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\files";
            string file = path + "\\transactions.json";

            Directory.CreateDirectory(path);

            using FileStream fs = new(file, FileMode.OpenOrCreate);
            using StreamWriter writer = new(fs);

            string json = JsonConvert.SerializeObject(Transactions);
            writer.Write(json);
        }

        public List<Transaction> GetTransactions() => Transactions;
    }
}
