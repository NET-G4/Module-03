namespace modul3_lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            #region Reference types, ref & out

            //Person person = new Person() { Id = 1, Name = "Tom" };
            //Person person1 = person;

            //Console.WriteLine(person.Name);
            //Console.WriteLine(person1.Name);

            //person1.Name = "Alice";

            //Console.WriteLine(person.Name);
            //Console.WriteLine(person1.Name);

            //DisplayInfo(ref person);

            //Console.WriteLine(person.Name);
            //Console.WriteLine(person1.Name);

            //int a = 1;
            //int b = 2;
            //int result;

            //int.TryParse(Console.ReadLine(), out result);

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Swap(ref a, ref b);

            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //Console.WriteLine(result);
            //AddTen(out result);
            //Console.WriteLine(result);

            #endregion

            Person personForStruct = new Person()
            {
                Id = 50,
                Name = "Struct person"
            };

            PersonStruct personStruct = new PersonStruct()
            {
                Person = personForStruct,
                Id = 1,
                Name = "John"
            };

            PersonStruct personStruct1 = personStruct;

            Console.WriteLine(personStruct.Name);
            Console.WriteLine(personStruct1.Name);

            personStruct.Name = "Tom";

            Console.WriteLine(personStruct.Name);
            Console.WriteLine(personStruct1.Name);

            UpdateStruct(personStruct);

            Console.WriteLine(personStruct.Id);
            Console.WriteLine(personStruct1.Id);

            int number = 10;
            MultiplyByTen(number);
            Console.WriteLine(number);

            personForStruct.Name = "John";

            Console.WriteLine(personStruct.Person.Name);
            Console.WriteLine(personStruct1.Person.Name);

            personStruct.Person = new Person()
            {
                Id = 40,
                Name = "Robert"
            };
            personStruct.Id = 500;

            Console.WriteLine(personStruct.Person.Name);
            Console.WriteLine(personStruct1.Person.Name);

            Person personTest = new Person()
            {
                Id = 1,
                Name = "Test"
            };
            Person personTest1 = personTest;

            personTest = new Person()
            {
                Id = 4,
                Name = "Changed"
            };

            // personTest.Name = "Changed";

            Console.WriteLine(personTest.Name);
            Console.WriteLine(personTest1.Name);

            personTest.PersonStruct = new PersonStruct()
            {
                Id = 1,
                Name = "Structo for Test"
            };

            Console.WriteLine(personTest.PersonStruct.Name);

            PersonStruct newStruct = personTest.PersonStruct;

            newStruct.Name = "Robert";

            Console.WriteLine(personTest.PersonStruct.Name);
            Console.WriteLine(newStruct.Name);
        }

        public static void DisplayInfo(ref Person person)
        {
            int a = 5;
            person = new Person() { Id = 4, Name = "Bob" };

            Console.WriteLine(person.Name);
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void AddTen(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        public static void UpdateStruct(PersonStruct person)
        {
            person.Id = 9;
            Console.WriteLine(person.Id);
        }

        public static void MultiplyByTen(int a)
        {
            a *= 10;
            Console.WriteLine(a);
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public PersonStruct PersonStruct { get; set; }
    }

    struct PersonStruct
    {
        public Person Person { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }

        public void ChangeName(string name)
        {
            Name = name;
=======
            Menu();
            DamolishKunimi();

        }

        static void Menu()
        {
            Console.WriteLine("1. Dushanba");
            Console.WriteLine("2. Seshanba");
            Console.WriteLine("3. Chorshanba");
            Console.WriteLine("4. Payshanba");
            Console.WriteLine("5. Juma");
            Console.WriteLine("6. Shanba");
            Console.WriteLine("7. Yakshanba");
            Console.WriteLine();
        }
        static void DamolishKunimi()
        {
            Console.Write("Marhamat tanlang - ");
            int number = int.Parse(Console.ReadLine());
            Console.Clear();

            HaftaKuni haftaKuni = (HaftaKuni)number;

            if (number != 6 && number != 7)
            {
                Console.Write(haftaKuni);
                Console.WriteLine(" dam olish kuni emas.");
                
            }
            else
            {
                Console.Write(haftaKuni);
                Console.WriteLine(" dam olish kuni");
            }
            
        }

        enum HaftaKuni
        {
            Dushanba = 1,
            Seshanba,
            Chorshanba,
            Payshanba,
            Juma,
            Shanba,
            Yakshanba
>>>>>>> Stashed changes
        }
    }
}