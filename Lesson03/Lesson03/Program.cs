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
       /* public delegate void PrintMessage();
        public delegate int Transform(int x);
        public delegate void DisplayNumber(int x);

        public delegate bool ValidateNumber(int number);
        public delegate void Greet(bool isSignedIn);
*/

        public delegate bool Any( int x, bool y);
        public delegate int Sum(int x);
        static void Main(string[] args)
        {
            


            #region Sample 1

            // PrintMessage printMessage = new PrintMessage(Hello);
            // PrintMessage printMessage = Hello;

            // printMessage.Invoke();
            //printMessage();
            //Console.WriteLine();

            //printMessage += World;
            //printMessage += Hello;

            //printMessage();

            //Console.WriteLine();

            //printMessage -= Hello;
            //printMessage -= Hello;
            //printMessage -= Hello;
            //printMessage -= World;

            //printMessage?.Invoke();
            //Console.WriteLine();

            //PrintMessage message1 = printMessage;
            //message1();
            //PrintMessage printMessage2 = message1 + printMessage;

            //printMessage2();

            #endregion

            int[] numbers =
                {1, 2, 3, 4 };
            Sum12(numbers, SumMM); 
            Sum12(numbers, SumMM1); 

            //Transform transformer = Square;
            //transformer += Cube;

            //int num = transformer(3);

            //TransformNumbers(numbers, Square, DisplayNumberWithColor);
            //TransformNumbers(numbers, Cube, WriteNumberToFile);

            //DisplayNumbers(numbers, IsEven);
            //DisplayNumbers(numbers, IsPositive);

            /*string language = Console.ReadLine();

            if (language == "uz")
            {
                StartApplication(WelcomeUserUzb);
            }
            else
            {
                StartApplication(WelcomeUserEn);
            }*/
        }

        public static void Sum12(int[] x, Sum delegate1)
        {
            int summ = 0;
            foreach (var i in x)
            {
                summ += delegate1(i);
            }
            Console.WriteLine(summ);
        }

        public static int SumMM(int x)
        {
           return x * x;
        }

        public static int SumMM1(int x)
        {
            return x + x;
        }

        /* static void DisplayHello(string name, int age)
         {
             if (age > 17)
             {
                 Console.WriteLine($"Hello: {name}. You can take driver license");
             }
             else
             {
                 Console.WriteLine($"Hello: {name}. You cannot take driver license");
             }
         }*/

        /*static void StartApplication(Greet greet)
        {
            bool isSignedIn = true;

            greet(isSignedIn);
        }
*/
        /*  static void WelcomeUserUzb(bool isSignedIn)
          {
              if (isSignedIn)
              {
                  Console.WriteLine("Qayta ko'rishdan xursandmiz!");
              }
              else
              {
                  Console.WriteLine("Xush kelibsiz!");
              }
          }*/

        /*static void WelcomeUserEn(bool isSignedIn)
        {
            if (isSignedIn)
            {
                Console.WriteLine("Welcome back!");
            }
            else
            {
                Console.WriteLine("Welcome!");
            }
        }

        static void DisplayNumbers(int[] numbers, Validator validator)
        {
            foreach (var number in numbers)
            {
                DisplayNumberWithColor(number, validator);
            }

            Console.WriteLine();
        }

        static void DisplayNumbers(int[] numbers, ValidateNumber validator)
        {
            foreach (var number in numbers)
            {
                DisplayNumberWithColor(number, validator);
            }

            Console.WriteLine();
        }

        static void TransformNumbers(int[] numbers, Transform transfomer, DisplayNumber displayer)
        {
            foreach (var number in numbers)
            {
                displayer(transfomer(number));
            }

            Console.WriteLine();
        }

        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static bool IsPositive(int x)
        {
            return x >= 0;
        }

        static void DisplayNumberWithColor(int x, ValidateNumber validator)
        {
            if (validator(x))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(x + " ");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(x + " ");
            Console.ResetColor();
        }

        static void DisplayNumberWithColor(int x, Validator validator)
        {
            if (validator.IsEven(x))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(x + " ");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(x + " ");
            Console.ResetColor();
        }

        static void DisplayNumberWithPositive(int x)
        {
            if (x < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(x + " ");
                Console.ResetColor();
                return;
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(x + " ");
            Console.ResetColor();
        }

        static void WriteNumberToFile(int x)
        {
            // Write to file
            Console.WriteLine($"Writing to file number: {x}");
        }

        static void TransformNumbersToSquare(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(Square(number) + " ");
            }

            Console.WriteLine();
        }

        static void TransformNumbersToCube(int[] numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(Cube(number) + " ");
            }

            Console.WriteLine();
        }

        static int Square(int x)
        {
            return x * x;
        }

        static int Cube(int x)
        {
            return x * x * x;
        }

        static void Hello()
        {
            Console.WriteLine("Hello");
        }

        static void World()
        {
            Console.WriteLine("World");
        }
    }

    class Validator
    {
        public bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        public bool IsPositive(int x)
        {
            return x >= 0;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int age { get; set; }
    }*/
    }
}