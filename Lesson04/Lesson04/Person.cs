namespace Lesson04
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}, Name: {Name}");
        }
    }
}
