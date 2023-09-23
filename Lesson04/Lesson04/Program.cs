using System.Runtime.ExceptionServices;

namespace Lesson04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] someNumbers = { 3, 21 , 24, 27, 9 , 91 , 63,-147};

            #region Count
            int Divisible3Count = Count(someNumbers, DivisibleBy3);
            int Divisible7Count = Count(someNumbers, DivisibleBy7);

            Console.WriteLine($"Massivdagi 3 ga bo'linuvchilar soni: {Divisible3Count}");
            Console.WriteLine($"Massivdagi 7 ga bo'linuvchilar soni: {Divisible7Count}");
            Console.WriteLine();
            #endregion
            #region Max
            int maxDivisible3 = Max(someNumbers, DivisibleBy3);
            int maxDivisible7 = Max(someNumbers, DivisibleBy7);

            Console.WriteLine($"Massiivdagi eng katta 3 ga bo'linuvchi : {maxDivisible3}");
            Console.WriteLine($"Massiivdagi eng katta 7 ga bo'linuvchi : {maxDivisible7}");
            Console.WriteLine();
            #endregion
            #region Min
            int minDivisible3 = Min(someNumbers, DivisibleBy3);
            int minDivisible7 = Min(someNumbers, DivisibleBy7);

            Console.WriteLine($"Massiivdagi eng kichik 3 ga bo'linuvchi : {minDivisible3}");
            Console.WriteLine($"Massiivdagi eng kichik 7 ga bo'linuvchi : {minDivisible7}");
            Console.WriteLine();
            #endregion
            #region Where
            int[] elementsDivisible3 = Where(someNumbers, DivisibleBy3);
            int[] elementsDivisible7 = Where(someNumbers, DivisibleBy7);

            Console.WriteLine("massivning 3 ga bo'linuvchi elementalari : ");
            foreach (int number in elementsDivisible3)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("massivning 7 ga bo'linuvchi elementalari : ");
            foreach (int number in elementsDivisible3)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            #region Converter
            decimal[] USD = { 10_000, 20_000, 4_000 };
            decimal[] RUB = { 10_000, 20_000, 4_000 };

            decimal[] UZS1 = Convert(USD, GetUSDCourse);
            decimal[] UZS2 = Convert(RUB, GetUSDCourse);

            Console.Write("USD : ");
            foreach(var i in USD)
            {
                Console.Write(i +  " ");
            }
            Console.WriteLine();

            Console.Write("UZS : ");
            foreach (var i in UZS1)
            {
                Console.Write(i +  " ");
            }
            Console.WriteLine();

            Console.Write("RUB : ");
            foreach (var i in RUB)
            {
                Console.Write(i +  " ");
            }
            Console.WriteLine();

            Console.Write("UZS : ");
            foreach (var i in UZS2)
            {
                Console.Write(i +  " ");
            }
            Console.WriteLine();
            #endregion
        }
        #region methods with delegates
        static int Count(int[] array, Predicate<int> predicate)
        {
            return array
                .Where(x => predicate(x))
                .ToList()
                .Count;
        }
        static int Max(int[] array, Predicate<int>predicate)
        {
            return array
                .Where(x => predicate(x))
                .Max();
        }
        static int Min(int[] array, Predicate<int> predicate)
        {
            return array
                .Where(x => predicate(x))
                .Min();
        }
        static int[] Where(int[] array , Predicate<int> predicate)
        {           
            return array
                .Where(x => predicate(x))
                .ToArray();

            ///simple version
            List<int> list = new List<int>();
            foreach(int i in array)
            {
                if (predicate(i))
                {
                    list.Add(i);
                }
            }
            return list.ToArray(); 
        }
        static decimal[] Convert(decimal[] array, Func<decimal, decimal> converter)
        {
            List<decimal> list = new List<decimal>();
            foreach(var i in array)
            {
                list.Add(converter(i));
            }
            return list.ToArray();
        }
        #endregion

        #region simple Methods
        static bool DivisibleBy3(int x)
        {
            return x % 3 == 0;
        }
        static bool DivisibleBy7(int x)
        {
            return x % 7 == 0;
        }
        static decimal GetUSDCourse(decimal x)
        {
            return x * 12_800;
        }
        static decimal GetRUBCourse(decimal x)
        {
            return x * 110;
        }
        #endregion

    }
}
