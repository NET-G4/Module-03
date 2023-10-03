namespace Lesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            ///stackda personForStruck nomli refence o'zgaruvchi ochilyapti => Class
            ///O'zida saqlayotgan Heapdagi xotira manziliga qiymatlarini saqlayapti
            ///



            PersonStruct personStruct = new PersonStruct()
            {
                Person = personForStruct,
                ///PersonStruct Stackdagi qiymat sifatida 
                ///personForStruct obyektining stackdagi qiymati => ya'ni
                ///Heapdagi joyining manzilini oldi

                Id = 1,

                ///Stackda
                ///yangi primitive toifa yaratildi va qiyamt berildi  

                Name = "John"
            };
            ///Yangi struct yaratilyapri ya'ni stackda o'zida value qiymat saqlovchi o'zgaruvchi
            ///Statckda o'zinig xususiyatlarini saqalayapti

            PersonStruct personStruct1 = personStruct;

            ///Stackda yangi personstruct1 o'zgaruvchisi olinyapti. 
            ///unga qiymat sifatida personStructning qiymatlari 
            ///nusxalanib berilyapti.

            Console.WriteLine(personStruct.Name);

            ///Console ga person struckning Name xususiyati Stackdan Chaqirilyapti

            Console.WriteLine(personStruct1.Name);

            ///Console ga personstruck1 ning Name xususiyati Stackdan Chaqirilyapti

            personStruct.Name = "Tom";
            ///personStruck ning Stackda Name xususiyati "Tom" ga almashtirilyapti
            ///Bu bilan faqat personStruckga tegishli value qiymat o'zgartirilyapti

            Console.WriteLine(personStruct.Name);
            ///personStruckning stackdan Name xususiyati chaqirilyapti ("Tom ga o'zgargan holati)
            ///namoyon bo'ladi

            Console.WriteLine(personStruct1.Name);
            ///personStruck1 ning stackdan Name xususiyati chaqirilyapti
            ///(Name xususiyati personStruckni nusxalab olinganidan beri o'zgartirilmagan
            ///(John qiymati aks ettiriladi)

            UpdateStruct(personStruct);
            ///Method chaqirilyapti va unga personStruct elementi 
            ///kiritliyapti. PersonStruct reference toifa emasligi uchun 
            ///uning faqat qiymatlari nusxalanib beriladi.
            ///O'zida esa o'zgarishlar mavjud bo'lmaydi

            Console.WriteLine(personStruct.Id);
            ///personStruct1 da o'zgarishlar mavjud emas
            ///Console da 1 akslanadi

            Console.WriteLine(personStruct1.Id);
            ///personStruct1 da o'zgarishlar mavjud emas
            ///=>ID = 1

            int number = 10;
            ///Stackda yangi int toifasida primitiv o'zgaruvchi ochildi
            ///va unga stacdagi qiymati sifatida 10 value qiymat berildi

            MultiplyByTen(number);
            ///number o'zgaruvchisi methodga chaqirilidi
            ///va u Hech qanday o'zgarish qabul qilmadi

            Console.WriteLine(number);
            ///Console ga numberning qiymati chaqirildi => 10 !; 

            personForStruct.Name = "John";
            ///personForStruct obyekti Name xususiyati "Johnga " o'zgartirildi
            ///"Person for struct "  =>  "John" 
            ///personForStruct Stackda saqalayotgan qiyamti bo'lmish
            ///heapdai joy manzili bir vaqtni  o'zida 3 ta obyektda mavjud 
            /// 1 perForStruct , 2 personStruct  , 3 personStruct1 
            /// ularning har biri orqali agar PersonForStruct ning heapdagi qiymatlariga
            /// o'zgartish kiritilsa ularning barchasida bu  o'zgartirish ko'rinadi

            Console.WriteLine(personStruct.Person.Name);
            Console.WriteLine(personStruct1.Person.Name);
            ///personStruct va personStruct1 da personForStruct obyekti qilgan  o'zgarsihlar
            ///aks etadi , chunki uchchovi ham bir xotira manziliga qarayapti

            personStruct.Person = new Person()
            ///personStruct ning Person o'zgaruvchisiga yangi qiymat yuklanyapti
            ///Ya'ni Heapdagi yangi ochilgan va qiymatlangan joy manzili!!
            {
                Id = 40,
                Name = "Robert"
            };

            personStruct.Id = 500;
            ///personStruct ning Id xususiyati 500 ga o'zgartirilyapti
            ///bunda uning Person xususiyatiGa tegishli Id o'zgarishsiz 
            ///qoladi

            Console.WriteLine(personStruct.Person.Name);
            ///Console ga personStruct Person xususiyati name chaqirilyapti
            ///Bunda Name xususiyati 145-qatoda o'zgarganligini inobatga olib
            ///"Robert" chiqadi
            ///
            Console.WriteLine(personStruct1.Person.Name);
            ///personStruct1 Person name xususiyati esa o'zgarishsiz "John " chiqadi
            ///Chunki personStruct1 person xususiyati hali ham personForStructning Heapdagi
            ///manziliga qaramoqda 
            ///
            Person personTest = new Person()
            ///Stackda yangi Person obyekti yaratilyapti
            ///unga qiymat sifatida Heapda yangi ochilgan va qiyamtlangan
            ///joy manzili berildi
            {
                Id = 1,
                Name = "Test"
            };

            Person personTest1 = personTest;
            ///Yangi personTest1 obyekti yartildi
            ///Stackdagi qiymati sifatida esa personTest ning Heapdagi Manzili
            ///nusxalab berildi

            personTest = new Person()
            ///personTest ga Stackda yangi qiymat berildi ya'ni
            ///Heapda yangi joy ochib , yangi joyning manzili berildi
            {
                Id = 4,
                Name = "Changed"
            };

            // personTest.Name = "Changed";

            Console.WriteLine(personTest.Name);
            ///Console ga personTestning Name xususiyati chaqirilyapti
            ///Stackdagi qiymat-manzil orqali Heapdagi yangi joyidagi Name qaytaradi

            Console.WriteLine(personTest1.Name);
            ///Eski personTestning manzilini olgani uchun 
            ///personTeset1 Stackdagi qiymat-manzil orqali personTestning eski Name xususiyatini
            ///qaytaradi, chunki personTest yangi manzilga qaraganda uning eski manzili
            ///personTest1 da saqalanib qolgani uchun o'zhib ketmagan !!!

            personTest.PersonStruct = new PersonStruct()
            ///personTest ning Heapdagi PersonStruct qiymatiga yangi qiymat berilmoqda 
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
        ///UpdateStruct methodi o'ziga PersonStruct o'zgaruvchi qabul qiladi va
        ///Stackda ma'lum vaqtga yangi PersonStruct obyekti yaratib ,
        ///unga qabul qilingan obyekt qiymatlari nusxalanadi.
        ///Bunda kiritilgan obyektga tashqi xavflar mavjud emas!!!
        ///Chunki unig faqat primitive qiymatlaridam foydalanilyapti
        {
            person.Id = 9;
            ///Stackda gi vaqtinchalik ochilgan obyekt
            ///ID xususiyati 9 ga o'zgartirilyapti
            Console.WriteLine(person.Id);
            ///Console ga vaqtinchalik obyektning Id xususiyati chqarilyapti => 9 aks ettiriladi!!!
        }/// Method tugashi bilan vaqtinchalik ochilgan va kiritilgan obyektni
         ///qiymatlarini nusxalagan obyekt o'chiriladi. 
         /// 

        public static void MultiplyByTen(int a)
        ///yangi method stackda yangi o'zgaruvchi ochilib
        ///unga qiymat sifatida kiritilgan primitive o'zgaruvchini
        ///stackdagi qiymati nusxalanib beriladi
        ///Bunda kiritlgan o'zgaruvchiga xavf majud emas !!!
        {
            a *= 10;
            ///Yangi ochilgan o'zgaruvchi Stackdagi qiymati
            ///10 ga ko'paytirilib o'zgartirildi
            Console.WriteLine(a);
            ///Console ga qiyamt chaqirildi => 100
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
        }
    }
}