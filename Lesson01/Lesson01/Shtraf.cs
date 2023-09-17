using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson01
{
    internal class Car
    {
        public int Id { get; set; }
        public string TexPasport { get; set; }
        public string CarNUmber { get; set; }

        public Car(int id, string texPasport, string carNumber)
        {
            Id = id;
            TexPasport = texPasport;
            CarNUmber = carNumber;
        }

        public void DisplayJarima()
        {
            List<string> JarimalarRoyxat = new List<string>();
            Console.WriteLine("Sizda ushbu jarimalar bor: ");
            int m = 100_000;
            for (int i = 1; i <= 5; i++)
            {
                int Raqam = i;
                int summa = m * i;
                JarimalarRoyxat.Add($"{Raqam}. {20 - i * 3}.09.2023 --> {summa}");
            }

            foreach (string number in JarimalarRoyxat)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
        }
        Stack<string> stack = new Stack<string>();
        Queue<string> queue = new Queue<string>();
        List<string> displaySumma = new List<string>();
        List<string> displayDate = new List<string>();
        public void JarimaTolash(int ID, string CarNumber)
        {
            if (ID == Id && CarNumber == CarNUmber)
            {
                DisplayJarima();
                Console.WriteLine(" -------- Qaysi jarimani tolamoqchisiz? ------- ");
                Console.Write("1. -> {100_000, 200_000, 300_000}");
                Console.WriteLine("\t2. -> {400_000, 500_000}");
                Console.Write("Tanlang - ");
                int n = int.Parse(Console.ReadLine());

                if(n == 1)
                {
                    queue.Enqueue("100_000 to`landi");
                    queue.Enqueue("200_000 to`landi");
                    queue.Enqueue("300_000 to`landi");
                    displaySumma.Add(queue.Dequeue());
                    displaySumma.Add(queue.Dequeue());
                    displaySumma.Add(queue.Dequeue());
                    stack.Push("17.09.2024");
                    stack.Push("20.09.2024");
                    stack.Push("23.09.2024");
                    displayDate.Add(stack.Pop());
                    displayDate.Add(stack.Pop());
                    displayDate.Add(stack.Pop());
                }
                else if(n == 2)
                {
                    queue.Enqueue("400_000 to`landi");
                    queue.Enqueue("500_000 to`landi");
                    displaySumma.Add(queue.Dequeue());
                    displaySumma.Add(queue.Dequeue());
                    stack.Push("26.09.2024");
                    stack.Push("29.09.2024");
                    displayDate.Add(stack.Pop());
                    displayDate.Add(stack.Pop());
                }              
            }
            else
            {
                Console.WriteLine("Bunaqa malumot topilmadi!");
            }
        }

        public void JarimalarTarixi()
        {
            Console.WriteLine("Summa boyicha!");
            foreach (string number1 in displaySumma)
            {
                Console.WriteLine(number1);
            }

            Console.WriteLine();
            Console.WriteLine("Sana boyicha!");
            foreach (string number2 in displayDate)
            {
                Console.WriteLine(number2);
            }
        }
    }
}
