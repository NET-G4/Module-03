namespace Lesson04
{
    internal class Program
    {
        public delegate void PrintMessage(string message);

        // Func<TResult>, Func<T1, TResult>, .... Func<T16, TResult>
        // Action<T1>, Action<T1, T2>, ... Action<T16>
        // Predicate<T>, Predicate<T1, T2>, ... Predicate<T16>
        static void Main(string[] args)
        {
            #region delegates review

            // PrintMessage messagePrinter = new Delegate(PrintMessage);
            //PrintMessage messagePrinter = PrintHello;
            //messagePrinter += PrintGoodbye;

            //messagePrinter("John");

            //messagePrinter.Invoke("Jane");

            //messagePrinter = null;

            //if (messagePrinter != null)
            //{
            //    messagePrinter("Robert");
            //}

            //messagePrinter?.Invoke("Robert");

            // --- //

            //Person person = new Person()
            //{
            //    Id = 1,
            //    Name = "John"
            //};

            //RegisterUser(person, GreetUser);
            //RegisterUser(person, GreetUserRu);
            //RegisterUser(person, GreetUserUz);

            #endregion

            #region Generics

            // PrintRed<string>("Hello");
            //PrintRed("Hello");
            //PrintRed(123);
            //PrintRed(true);

            //Student student = new Student()
            //{
            //    Id = 2,
            //    Name = "Jane",
            //    StudentNumber = 512
            //};

            // student.DisplayInfo();

            // PrintRed(student);

            // var newStudent = PrintRed<Student, int>(student, 2);

            //Person john = new Student();
            //john.Id = 4;
            //john.Name = "John";
            //Student student = (Student)john;
            //student.StudentNumber = 5;

            //Console.WriteLine(student.Name);
            //student.DisplayInfo();

            //Console.WriteLine();
            //student.Name = "Student";

            //Console.WriteLine(student.Name);
            //Console.WriteLine(john.Name);

            #endregion

            //ExecuteOperation(5, 7, Add, PrintGreen<int>);
            //ExecuteOperation(5, 7, Multiply, PrintRed);
            //ExecuteOperation(5, 7, Subtract, PrintBlue);
        }

        #region Delegate methods

        static void RegisterUser(Person person, PrintMessage printMessage)
        {
            // database -> registration

            bool isSuccess = true; //registration

            if (isSuccess)
            {
                printMessage(person.Name);
            }
        }

        static void GreetUser(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }

        static void GreetUserUz(string name)
        {
            Console.WriteLine($"Salom, {name}");
        }

        static void GreetUserRu(string name)
        {
            Console.WriteLine($"Привет, {name}");
        }

        static void PrintHello(string name)
        {
            Console.WriteLine($"Hello: {name}");
        }

        static void PrintGoodbye(string name)
        {
            Console.WriteLine($"Goodbye: {name}");
        }

        static int CalculateLength(string name)
        {
            return name.Length;
        }

        static void PrintError(string errorMessage, int errorCode)
        {
            Console.WriteLine($"Error: {errorMessage} ({errorCode})");
        }

        static void ExecuteOperation(int a, int b, Func<int, int, int> func, Action<int> display)
        {
            int result = func(a, b);

            display(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        #endregion

        #region Generic methods

        static void PrintGreen<T>(T value) where T : struct
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        static void PrintRed<T>(T value) where T : struct
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        static void PrintBlue<T>(T value) where T : struct
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        #endregion
    }
}