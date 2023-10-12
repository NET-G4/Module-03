namespace Lesson11.Models
{
    internal class Transaction
    {
        private static int _id = 1;
        public int Id { get; private set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public TransactionType Type { get; set; }

        public Transaction()
        {
            Id = _id++;
        }

        public string GetShortDetail() => $"{Id}, {TransactionDate}, {GetAmount()}";

        private string GetAmount()
        {
            return Type == TransactionType.Income
                ? $"+{Math.Abs(Amount)}"
                : $"-{Math.Abs(Amount)}";
        }

        public override string ToString()
        {
            return $"Id: [{Id}] \nDescription: [{Description}] \nDate: [{TransactionDate}] \nAmount: [{Amount}]";
        }
    }

    enum TransactionType
    {
        Income,
        Expense
    }
}
