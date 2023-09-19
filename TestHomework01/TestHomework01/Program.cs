namespace TestHomework01
{
    internal class Program
    {
        public static Dictionary<Car, List<Jarima>> jarimalar = new Dictionary<Car, List<Jarima>>();
        static void Main(string[] args)
        {

            Car car = new Car("75 e712vs", "Cobalt");
            List<Jarima> jarima = new List<Jarima>();
            jarimalar.Add(car,jarima);

            Jarima jarma1 = new Jarima(10_000,DateTime.Now,"qizil chiroq");
            Jarima jarma2 = new Jarima(1_000, DateTime.Now, "qizil chiroq");
            Jarima jarma3 = new Jarima(20_000, DateTime.Now, "qizil chiroq");
            Jarima jarma4 = new Jarima(30_000, DateTime.Now, "qizil chiroq");
            Jarima jarma5 = new Jarima(40_000, DateTime.UtcNow, "qizil chiroq");

            AddJarima(car, jarma1);
            AddJarima(car, jarma2);
            AddJarima(car, jarma3);
            AddJarima(car, jarma4);
            AddJarima(car, jarma5);


            
            DisplayAllJarima(car);

            PayJarima(car, 2);
            PayJarima(car, 3);

            Console.ReadKey();

            DisplayPaidJarima(car);

            Console.ReadKey();
            
            DisplayUnPaidJarima(car);

            Console.ReadKey();
        }    
        static void  AddJarima(Car car, Jarima jarima)
        {
            jarimalar[car].Add(jarima);
        }
        static void PayJarima(Car car , int id)
        {
            jarimalar[car]
                .Where(x => x.ID == id)
                .Single()
                .IsPaid = true;
        }
        static void DisplayPaidJarima(Car car)
        {
            Console.Clear();
            foreach(var jarima in jarimalar[car])
            {
                if (jarima.IsPaid)
                {
                   jarima.DisplayInfo();
                }
            }
        }
        static void DisplayUnPaidJarima(Car car)
        {
            Console.Clear();
            foreach(Jarima jarima in jarimalar[car])
            {
                if (!jarima.IsPaid)
                {
                    jarima.DisplayInfo();
                }
            }
        }
        static void DisplayAllJarima(Car car)
        {
            Console.Clear();
            foreach(var jarima in jarimalar[car])
            {
                jarima.DisplayInfo();
            }
        }
    }

}