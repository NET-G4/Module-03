namespace Lesson04
{
    internal class Program
    {
        public delegate bool Predicate1<T>(int t, int max);

        static void Main(string[] args)
        {
            int[] numbers = { 1, 9, 3, 4, -5, -6, -7, 8 };
            Where(numbers, NegativeNumbers);
        }
        static void Count(int[] number, Predicate<int> predicate)
        {
            int counter = 0;
            foreach (int i in number)
            {
                if (predicate(i))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
        static void Max(int[] number, Predicate1<int> predicate)
        {
            int max = 0;
            for (int i = 0; i < number.Length; ++i)
            {
                if (predicate(max, number[i]))
                {
                    max = number[i];
                }
            }
            Console.WriteLine(max);
        }
        static void Min(int[] number, Predicate1<int> predicate)
        {
            int min = number[0];
            for (int i = 1; i < number.Length - 1; ++i)
            {
                if (predicate(min, number[i]))
                {
                    min = number[i];
                }
            }
            Console.WriteLine(min);
        }
        static void Where(int[] number, Predicate<int> predicate)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < number.Length; ++i)
            {
                if (predicate(number[i]))
                {
                    numbers.Add(number[i]);
                }
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
        static bool NegativeNumbers(int num)
        {
            if (num < 0)
            {
                return true;
            }
            return false;
        }
        static bool MinMax(int num1, int max)
        {
            if (num1 < max)
            {
                return true;
            }
            return false;
        }
        static bool Positive(int number)
        {
            if (number < 0)
            {
                return false;
            }
            return true;
        }
        static bool MinNumber(int number, int min)
        {
            if (min < number)
            {
                return true;
            }
            return false;
        }
    }
}

