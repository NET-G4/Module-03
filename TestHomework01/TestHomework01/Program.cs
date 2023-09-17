namespace TestHomework01
{
    internal class Program
    {
        public static Dictionary<Car, List<Jarima>> jarimalar = new Dictionary<Car, List<Jarima>>();
        static void Main(string[] args)
        {
            Jarima jarma1 = new Jarima(10_000,DateTime.Now,"Toshkent");
        }    
        static void  AddJarima(Car car, Jarima jarima)
        {
            jarimalar[car].Add(jarima);
        }
        static void PayJarima(Car car , int id)
        {
                   
        }
    }

}