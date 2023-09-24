using System.Reflection.PortableExecutable;

namespace lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kuni kiriting:");
            int number=int.Parse(Console.ReadLine());
            DayOfWeek dayOfWeek = (DayOfWeek)number;
            ChooseDayOfWeek(dayOfWeek);
            
            Main(args);
        }
        enum DayOfWeek
        {
            Dushanba=1,
            Seshanba=2,
            Chorshanba=3,
            Payshanba=4,
            Juma=5,
            Shanba=6,
            Yakshanba=7,
        }

        static void ChooseDayOfWeek(DayOfWeek dayOfWeek) 
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Dushanba:
                    Console.WriteLine("Dushanba Ish kuni");
                    break;
                    case DayOfWeek.Seshanba:
                    Console.WriteLine("Seshanba Ish kuni");
                    break;
                    case DayOfWeek.Chorshanba:
                    Console.WriteLine("Chorshanba Ish kuni");
                    break;
                    case DayOfWeek.Payshanba:
                    Console.WriteLine("Payshanba Ish kuni");
                    break;
                    case DayOfWeek.Juma:
                    Console.WriteLine("Juma Ish kuni");
                    break;
                case DayOfWeek.Shanba:
                    Console.WriteLine("Shanba Dam olish kuni");
                    break;
                    case DayOfWeek.Yakshanba:
                    Console.WriteLine("Yakshanba Dam olish kuni");
                    break;
                default:
                    Console.WriteLine("Siz notogri Kun kiritingiz! \nIltimos 1-7 oralig'ida kun belgilang!");
                    break;
            }
            

        }
    }
}