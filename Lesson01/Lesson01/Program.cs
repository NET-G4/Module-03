namespace Lesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        // Homework
        // Complete the following method
        public static int Add(int a, int b)
        {
            if (a < b)
            {
                Console.WriteLine($"{a} smaller than {b}");
                return 0;
            }
            return a - b;
        }
    }
}