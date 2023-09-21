namespace Lesson03
{
    // 1. All(numbers, bool (int) => bool) -> bool
    // delegat bilan xar bir son chaqirilganda barcha chaqiruv
    // true qaytarsa Metod.All true qaytaradi, agardi bironta son
    // bilan delegat chaqirilganda false qaytsa Metod.All xam false
    // qaytaradi.
    // 2. Any(numbers, bool (int) => bool) -> bool
    // delegat bilan xar bir son chaqirilganda barcha chaqiruv
    // false qaytarsa Metod.All false qaytaradi, agardi bironta son
    // bilan delegat chaqirilganda true qaytsa Metod.All xam true
    // qaytaradi.
    // 3. Sum(numbers, int (int) => int) -> int
    // delegat bilan xar bir son chaqirilganda barcha chaqiruvni natijasini
    // yig'ib umumiy natijani qaytaradi.
    // 4. Average(numbers, int (int) => int) -> double
    // delegat bilan xar bir son chaqirilganda barcha chaqiruvni natijasini
    // yig'ib umumiy o'rta qiymatini (sum / n) qaytaradi.
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
        static bool Any(List<int> numbers , ValidateAny validator)
        {
            return numbers.Any(x => validator(x));
        }
        static int Summ(List<int> numbers ,ValidateSum validator)
        {
            int sum = 0;
            foreach(int i in numbers)
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
            return sum/numbers.Count;
        }
    }
}