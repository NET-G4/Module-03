namespace Lesson04
{
    internal class Student : Person, IRunnable
    {
        public int StudentNumber { get; set; }

        public void Run()
        {
            Console.WriteLine("Student is running.");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"S number: {StudentNumber}");
        }
    }
}
