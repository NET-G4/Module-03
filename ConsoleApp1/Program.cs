namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Sarvar Abduvoxidov");
            Person person1 = new Person("Zuhriddin Raximov");
            Person person2 = new Person("Muhammadrizo Tursunov");
            Person person3 = new Person("Abdurahmon Xayitov");

            person2.AddPenalty(new Penalty("Piyodaga yo'l bermadim", "10.10.2023", 132_000));
            person2.AddPenalty(new Penalty("Xavfsizlik kamari taqmagan", "14.10.2023", 292_000));
            person2.AddPenalty(new Penalty("Qizil chiroqda xarakatlanish ", "17.11.2023", 412_000));
            person2.AddPenalty(new Penalty("Qizil chiroqda xarakatlanish ", "18.11.2023", 412_000));


            person2.AddPayout(new Penalty("Taqiqlangan joyga to'xtash", "10.11.2023", 332_000));
            person2.AddPayout(new Penalty("GAI xodimidan qochish", "14.11.2023", 1_532_000));
            Menu();

            Main(args);
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("           Passport id orqali jarimalarni tekshiring!\n\n");

            int id = 0;

            Console.Write("Type passport id: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Iltimos faqat raqam kiriting!");
                Console.Write("Type passport id: ");
            }

            Person shaxs;

            if(!Person.Persons.TryGetValue(id, out shaxs))
            {
                Console.WriteLine($"{id} bu id raqamiga ega foydalanuvchi topilmadi");
                Console.WriteLine("\n\nPress any key to continue.....");
                Console.ReadKey();
                return;
            }


            switch (PenaltysMenu())
            {
                case 1:
                    shaxs.DisplayPenaltys();
                    Console.WriteLine("\n\nPress any key to continue.....");
                    Console.ReadKey();
                    break;
                case 2:
                    shaxs.DisplayPayouts();
                    break;
                default:
                    break;
            }
            
        }

        static int PenaltysMenu()
        {
            Console.Clear();
            Console.WriteLine("              Jarimalar bo'limi\n\n");
            Console.WriteLine("         1.Penaltys       2.Payouts \n\n");

            int num;
            Console.Write("Type the number: ");
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Iltimos faqat menudan birini tanlang!");
                    Console.Write("Type the number: ");
                }

                if (num < 1 || num > 2)
                {
                    Console.WriteLine("Iltimos faqat menudan birini tanlang!");
                    Console.Write("Type the number: ");
                    continue;
                }

                break;
            }
            return num;
        }
    }
}