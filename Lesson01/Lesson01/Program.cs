namespace Lesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Add(1,5));

        }

        // Homework
        // Complete the following method
        public static int Add(int a, int b)
        {
            if (a > 0 || b > 0)
            {
                return a + b;
            }
            return 0;
        }
    }
}