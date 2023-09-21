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
        public delegate bool CheckEvenNumber(int x);
        public delegate bool CHeckNumberOdd(int x);
        public delegate int AverageNumber(int x);
        public delegate int AvregeNum(int x);

        static void Main(string[] args)
        {
            int[] number = { 2, 2, 4, 8, 10 };
            int[] number1 = { 1, 3, 5, 9, 7 };
            CheckNumber(number, All);
            CheckOdd(number1, All);
            AverageValue(number, Sum);
            Average(number1, Aver);
        }
        static void CheckNumber(int[] number, CheckEvenNumber checkEvenNumber)
        {
            foreach (int num in number)
            {
                if (!checkEvenNumber(num))
                {
                    Console.WriteLine("False");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("True");
        }
        static bool All(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;
        }
        static void CheckOdd(int[] number1, CHeckNumberOdd cHeckNumberOdd)
        {
            foreach (int num in number1)
            {
                if (cHeckNumberOdd(num))
                {
                    Console.WriteLine("True");
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("False");
        }
        static void AverageValue(int[] number, AverageNumber averageNumber)
        {
            int sumResult = 0;
            foreach (int num in number)
            {
                int result = averageNumber(num);
                sumResult += result;
            }
            int average = sumResult / number.Length;
            Console.WriteLine($"O'rta qiymat: {average}");
        }
        static int Sum(int x)
        {
            return x;
        }
        static void Average(int[] number1, AvregeNum avregeNum)
        {
            int sum = 0;
            foreach (int num1 in number1)
            {
                sum += avregeNum(num1);
            }
            Console.WriteLine(sum);
        }
        static int Aver(int x)
        {
            return x;
        }
    }
}