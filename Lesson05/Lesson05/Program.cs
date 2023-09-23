namespace Lesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Display(person);

            Animal animal = new Animal();
            Display(animal);

            Cat cat = new Cat();
            Display(cat);
        }

        static void Display(IRunnable runnable)
        {
            runnable.Run();
        }
    }

    interface IRunnable
    {
        public void Run();
    }

    class Person : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Person Running");
        }
    }

    class Animal : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Animal running");
        }
    }

    class Cat : IRunnable
    {
    }
}