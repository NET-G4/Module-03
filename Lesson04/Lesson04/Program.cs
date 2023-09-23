using System.ComponentModel.DataAnnotations;

namespace Lesson04
{
    internal class Program
    {
        public delegate void Print1(string som);

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

            int[] number = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            decimal[] numberValutaUSD = { 100, 1000, 43, 12, 56, 113 };
            decimal[] numberValuteUZS = { 1_000_000, 1_2374_000, 3_000, 34_000};

            #region Count

            /*Console.WriteLine(Count(number, IsEven));
            Console.WriteLine(Count(number, IsPositive));
            Console.WriteLine(Count(number, IsOdd));*/

            #endregion


            #region Max
            /*
            Console.WriteLine(Max1(number, IsEven));
            Console.WriteLine(Max1(number, IsOdd));
            Console.WriteLine(Max1(number, IsNegative));
            Console.WriteLine(Max1(number, Ildiz));
            */
            #endregion


            #region WHERE
            /*
            Where(number, IsEven);
            Console.WriteLine();
            Where(number, Ildiz);
            Console.WriteLine();
            Where(number, IsOdd);
            */
            #endregion
            
            #region CONVERTER

            Convert(numberValutaUSD, USD_UZS);
            Console.WriteLine("---------------------");
            Convert(numberValuteUZS, UZS_USD);

            #endregion


        }

        #region Count method
        public static int Count(int[] numbers, Predicate<int> predicate)
        {
            int count = 0;
            foreach (int i in numbers)
            {
                if (predicate(i) == true)
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region MaxMethod
        public static int Max1(int[] numbers, Predicate<int> predicate)
        {
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (predicate(numbers[i]))
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                    }
                }
            }
            return max;
        }

        #endregion

        #region WhereMethod

        public static void Where(int[] numbers, Predicate<int> predicate)
        {
            int[] arr = new int[100];
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (predicate(numbers[i]))
                {
                    arr[count] = numbers[i];
                    count++;
                }
                // Console.WriteLine();
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(arr[i] + " ");
            }
            //return 1;
        }

        #endregion

        #region ConvertMethod

        public static void Convert(decimal[] decimals, Func<decimal, decimal> converter)
        {
            for (int i = 0; i < decimals.Length; i++)
            {
                decimals[i] = converter(decimals[i]);
                Console.WriteLine(decimals[i] + " ");
            }
        }

        #endregion

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

        static bool Ildiz(int number)
        {
            double a = Math.Sqrt(number);
            double b = Math.Pow(a, 2);

            return (number == b);
        }

        public static decimal USD_UZS(decimal decimals)
        {
            decimal HozirgiKursUSD = 12374;//somda  1usd 

            return HozirgiKursUSD * decimals;
        }

        public static decimal UZS_USD(decimal decimals)
        {
            decimal HozirgiKursUZS = (decimal)0.081; 

            return HozirgiKursUZS * decimals;
        }
        public static void SOM(string som)
        {
            Console.WriteLine(" som");
        } 
        public static void Dollar(string dollar)
        {
            Console.WriteLine(" $");
        }
    }
}
