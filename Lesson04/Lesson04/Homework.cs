namespace Lesson04
{

    public delegate bool NumberCheck(int number);
    public delegate int Calculate(int number);

    internal static class Homework
    {
        public static bool All(int[] array, NumberCheck checker)
        {
            foreach (var number in array)
            {
                if (!checker(number))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool AllPredicate(int[] array, Predicate<int> predicate)
        {
            foreach (var number in array)
            {
                if (!predicate(number))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool Any(int[] array, NumberCheck checker)
        {
            foreach (var number in array)
            {
                if (checker(number))
                {
                    return true;
                }
            }

            return false;
        }

        public static bool AnyPredicate(int[] array, Predicate<int> predicate)
        {
            foreach (var number in array)
            {
                if (predicate(number))
                {
                    return true;
                }
            }

            return false;
        }

        public static int Sum(int[] array, Calculate calculate)
        {
            int sum = 0;

            foreach (var number in array)
            {
                sum += calculate(number);
            }

            return sum;
        }

        public static int SumFunc(int[] array, Func<int, int> func)
        {
            int sum = 0;

            foreach (var number in array)
            {
                sum += func(number);
            }

            return sum;
        }

        public static int Average(int[] array, Calculate calculate)
        {
            int sum = 0;
            // 1 + 4 + 9 + 16 + 25 = 55
            foreach (var number in array)
            {
                sum += calculate(number);
            }

            return sum / array.Length;
        }

        public static int AverageFunc(int[] array, Func<int, int> func)
        {
            int sum = 0;

            foreach (var number in array)
            {
                sum += func(number);
            }

            return sum / array.Length;
        }
    }
}
