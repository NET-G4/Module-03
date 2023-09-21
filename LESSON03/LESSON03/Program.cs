namespace LESSON03
{
    internal class Program
    {
        public delegate bool ValidateAll(int number);
        public delegate bool ValidateAny(int number);
        public delegate int ValidateSum(int number);
        public delegate int ValidateAverage(int number);
        static void Main(string[] args)
        {

        }

        static bool All(List<int> numbers, ValidateAll validator)
        {
            return numbers.All(x => validator(x));
        }
        static bool Any(List<int> numbers, ValidateAny validator)
        {
            return numbers.Any(x => validator(x));
        }
        static int Sum(List<int> numbers, ValidateSum validator)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                sum += validator(i);
            }
            return sum;
        }
        static double Average(List<int> numbers, ValidateAverage validator)
        {
            double sum = 0;
            foreach (int i in numbers)
            {
                sum += validator(i);
            }
            return sum / numbers.Count;
        }
    }
}