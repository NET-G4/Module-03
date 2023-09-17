namespace Lesson01
{
    internal class Program
    {
        // 1. List
        // 2. Queue
        // 3. Stack
        // 4. Dictionary
        // 5. HashSet

        static void Main(string[] args)
        {

            Car car = new Car(0,   "A123B0",    "25 A 213 CD");
            /*Shtaraf shtaraf1 = new Shtaraf(1,  "A8236B9",   "01 B 456 AA");
            Shtaraf shtraf2 = new Shtaraf(2,   "B1234B6",   "20 B 218 BB");
            Shtaraf shtraf3 = new Shtaraf(3,   "A453B0",    "30 C 598 CD");
            Shtaraf shtraf4 = new Shtaraf(4,   "K8236B9",   "40 E 456 AA");
            Shtaraf shtraf5 = new Shtaraf(5,   "G434B6",    "50 G 218 BB");
            Shtaraf shtraf6  = new Shtaraf(6,  "A123B0",    "60 K 213 CD");
            Shtaraf shtraf7 = new Shtaraf(7,   "B6456B9",   "70 L 569 AA");
            Shtaraf shtraf8 = new Shtaraf(8,   "B1234B6",   "80 S 658 BB");
            Shtaraf shtraf9 = new Shtaraf(9,   "A123B0",    "85 T 123 CD");
            Shtaraf shtraf10 = new Shtaraf(10, "A8236B9",   "90 O 876 AA");
            Shtaraf shtraf11 = new Shtaraf(11, "B1234B6",   "10 Q 188 BB");*/

            //car.DisplayJarima();
            car.JarimaTolash(0, "25 A 213 CD");
            Console.WriteLine();
            car.JarimalarTarixi();
            
            #region List

            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //numbers.Remove(3);
            //numbers.Remove(4);

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Queue

            //Queue<int> queue = new Queue<int>();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);

            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            #endregion

            #region Stack

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Peek());

            #endregion

            #region Dictionary

            //Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            //keyValuePairs.Add(1, "One");
            //keyValuePairs.Add(2, "Two");
            //keyValuePairs.Add(3, "Three");
            //keyValuePairs.Add(4, "Four");
            //keyValuePairs.Add(5, "Five");

            //Console.WriteLine(keyValuePairs[1]);
            //Console.WriteLine(keyValuePairs.TryGetValue(1, out string result));
            //Console.WriteLine(result);
            //// Console.WriteLine(keyValuePairs[6]); -> Exception

            //Console.WriteLine(keyValuePairs.ContainsValue("One"));
            //Console.WriteLine(keyValuePairs.ContainsKey(6));


            //keyValuePairs.Add(6, "One");

            //Console.WriteLine(keyValuePairs[1]);
            //keyValuePairs[1] = "Ten";
            //Console.WriteLine(keyValuePairs[1]);

            //keyValuePairs.Remove(1);

            #endregion

            #region Hashset

            /*HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);

            Console.WriteLine(set.Count);
            Console.WriteLine(set.TryGetValue(1, out int num));
            Console.WriteLine(num);
            Console.WriteLine(set.Contains(1));

            set.Remove(2);*/

            #endregion
        }
    }

    // Shtraflar
    // 1. 10.12.23
    // 2. 11.12.23
    // 3. 12.12.23

    // To'lovlar
    // 15.12.23
    // 14.12.23
    // 13.12.23
}