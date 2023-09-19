using System;
using System.Reflection.Metadata.Ecma335;

namespace Lesson__1
{
    internal class Program
    {
        static Dictionary<string, List<Penalty>> penaltiesDatabase = new Dictionary<string, List<Penalty>>();

        static void Main(string[] args)
        {
            Person person = new Person("Aliyev A.V.","12.12.2000");///ID=1000_000
            
         
            person.AddPenalty(new Penalty("01.01.2023","Toshkent","125-modda 1-band",165_000));
            person.AddPenalty(new Penalty("13.03.2023", "Oxangaron", "128-modda 2-band", 330_000));
            person.AddPenalty(new Penalty("14.06.2023", "Olmaliq", "125 - modda 3-band ", 330_000));
            person.AddPenalty(new Penalty("15.08.2023", "Parkent", "125 - modda 4- band", 990_000));


            person.AddPayment(new Penalty("01.01.2023", "Toshkent", "125-modda 1-band", 165_000));
            person.AddPayment(new Penalty("13.03.2023", "Oxangaron", "128-modda 2-band", 330_000));
            Menu();

            Main(args);
        }
        static void Menu()
        {

            Console.WriteLine("\t\t\t\t Asosiy menyu:\n");
            

            int id = 0;
            Console.Write("Iltimos passport Id raqamini kiriting:  ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Ushbu Id topilmadi iltimos qayta urinib ko'ring:");
                Console.WriteLine("Iltimos passport Id raqamini kiriting:");
            }
           
            if (!Person.persons.TryGetValue(id, out Person haydovchi))
            {
                Console.WriteLine($"Ushbu {id} raqamiga ega shaxs topilmadi:");
                Console.WriteLine("Davom etish uchun istalgan tugmani bosing.");
                Console.ReadKey();
                return;
            }

            static int PenaltysMenu()
            {
                Console.Clear();
                Console.WriteLine("\nJarimalar haqida ma'lumot olish uchun 1 raqamini bosing:    \n \nTo'lovlar haqida ma'lumot olish uchun 2 raqamini bosing: ");
                

                int num = 0;
                while (true)
                {
                    if(!int.TryParse(Console.ReadLine(),out num))
                    {
                        Console.WriteLine("Iltimos menyudagi raqamlardan birini tanlang:");
                        Console.WriteLine("Raqamni kirting:");
                    }
                    if (num <1 ||num>2 )
                    {
                        Console.WriteLine("Iltimos menyudagi raqamlardan birini tanlang:");
                        Console.WriteLine("Raqamni kirting:");
                    }
                    break;
                }
                return num;
            }

            switch (PenaltysMenu())
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Jarimalar haqida malumotlar: ");
                    haydovchi.DisplayInfoPerson();
                    haydovchi.DisplayPenaltys();    
                    Console.WriteLine("Menyuga qaytish uchun 1 ni bosing:   \t Ilovadan chiqish uchun 2 ni bosing:");
                    int number = int.Parse(Console.ReadLine());
                    switch(number)
                    {
                        case 1:
                            Console.Clear();
                            Menu();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;       
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Jarima to'lovlari haqida malumotlar: ");
                    haydovchi.DisplayInfoPerson();
                    haydovchi.DisplayPayment();
                    Console.WriteLine("Menyuga qaytish uchun 1 ni bosing:   \t Ilovadan chiqish uchun 2 ni bosing:");
                    int number1 = int.Parse(Console.ReadLine());
                    switch (number1)
                    {
                        case 1:
                            Console.Clear();
                            Menu();
                            break;
                        case 2:
                            Environment.Exit(0);
                            break;
                    }                 
                    break;
                default:
                    break;
            }

        }   

    }
}