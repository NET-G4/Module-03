namespace Lesson04
{
    internal class Program
    {
        // 1.
        // COUNT(int[] array, Predicate<int> predicate) -> int
        // massiv qabul qilib, shartni qanoatlantiradigan
        // elementlar sonini qaytaradi
        // 2.
        // MAX(int[] array, Predicate<int> predicate) -> int
        // massiv qabul qilib, shartni qanoatlantiradigan
        // elementlardan maksimal qiymanti qaytaradi
        // 3.
        // MIN(int[] array, Predicate<int> predicate) -> int
        // massiv qabul qilib, shartni qanoatlantiradigan
        // elementlardan minimal qiymanti qaytaradi
        // 4.
        // Where (int[] array, Predicate<int> predicate) -> int[]
        // massiv qabul qilib, shartni qanoatlantiradigan elementlarni
        // massivini qaytaradi.
        // 5.
        // Convert(decimal[] array, Func<decimal, decimal> converter) -> decimal[]
        // massiv qabul qilib, sonlarni o'zgartirib elementlarni natijasini qayataridi

        public static void Main(string[] args)
        {
            int[] evenNumbers = { 2, 4, 6, 8, 10 };
            int[] oddNumbers = { 1, 3, 5, 7, 9 };
            int[] evenNumbersWithOneOdd = { 2, 4, 6, 8, 9 };
            int[] oddNumbersWithOneEven = { 1, 3, 5, 7, 8 };

            int[] positiveNumbers = { 1, 2, 3, 4, 5 };
            int[] negativeNumbers = { -1, -2, -3, -4, -5 };
            int[] positiveNumbersWithOneNegative = { 1, 2, 3, 4, -5 };
            int[] negativeNumbersWithOnePositive = { -1, -2, -3, -4, 5 };

            #region All

            Console.WriteLine("---- All ----");

            // check if all numbers are positive
            bool isAllEven = Homework.All(evenNumbers, IsEven); // true
            bool isAllOdd = Homework.All(oddNumbers, IsOdd);
            bool res1 = Homework.All(evenNumbersWithOneOdd, IsEven);
            bool res2 = Homework.All(oddNumbersWithOneEven, IsOdd);

            Console.WriteLine(isAllEven);
            Console.WriteLine(isAllOdd);
            Console.WriteLine(res1);
            Console.WriteLine(res2);

            #endregion

            #region Any

            Console.WriteLine("---- Any ----");

            bool any1 = Homework.Any(positiveNumbers, IsNegative); // true
            bool any2 = Homework.Any(negativeNumbers, IsPositive);
            bool any3 = Homework.Any(positiveNumbersWithOneNegative, IsNegative);
            bool any4 = Homework.Any(negativeNumbersWithOnePositive, IsPositive);

            Console.WriteLine(any1);
            Console.WriteLine(any2);
            Console.WriteLine(any3);
            Console.WriteLine(any4);

            #endregion

            #region Sum

            Console.WriteLine("---- Sum ----");

            int sum1 = Homework.Sum(positiveNumbers, Square); // 55
            int sum2 = Homework.Sum(negativeNumbers, Square);
            int sum3 = Homework.SumFunc(positiveNumbersWithOneNegative, Cube);
            int sum4 = Homework.SumFunc(negativeNumbersWithOnePositive, Cube);

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
            Console.WriteLine(sum4);

            #endregion

            #region Average

            Console.WriteLine("---- Average ---- ");

            int average1 = Homework.Average(positiveNumbers, Square);
            int average2 = Homework.Average(negativeNumbers, Square);
            int average3 = Homework.AverageFunc(positiveNumbersWithOneNegative, Cube);
            int average4 = Homework.AverageFunc(negativeNumbersWithOnePositive, Cube);

            Console.WriteLine(average1);
            Console.WriteLine(average2);
            Console.WriteLine(average3);
            Console.WriteLine(average4);

            #endregion
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        static bool IsPositive(int number)
        {
            return number >= 0;
        }

        static bool IsNegative(int number)
        {
            return number < 0;
        }

        static int Square(int number)
        {
            return number * number;
        }

        static int Cube(int number)
        {
            return (int)Math.Pow(number, 3);
        }
    }
}
