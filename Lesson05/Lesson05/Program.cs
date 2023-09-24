namespace Lesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Ma'lumotaringizni kiriting ");
                Console.WriteLine();

                Console.Write("Ism familiangiz : ");
                string name = Console.ReadLine();

                Console.Write("Yoshingiz : ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Jinsingiz : 1.Erkak   2.Ayol ");
                int gender = int.Parse(Console.ReadLine());

                Console.WriteLine("Ma'lumotingiz (1.Magistr \t2.Bakalavr \t3.O'rta maxsus \t4.O'rta)");
                int education = int.Parse(Console.ReadLine());

                Candidate candidate1 = new Candidate(name,age,(Gender)gender, (Education)education);
              
            }
            catch(CandidateAdult)
            {
                Console.WriteLine("Faqat voyaga yetgan shaxslar qabul qilinadi!");
            }
            catch (CandidateShouldMale)
            {
                Console.WriteLine("Uzr faqat erkak ishchilar qabul qilinadi!");
            }
            catch (ShouldGraduatedUniversity)
            {
                Console.WriteLine("Universitetni tugating!");
            }
            catch (Exception)
            {
                Console.WriteLine("Nimadir xato!");
            }
            finally
            {
                Console.WriteLine("================================================");
                Console.WriteLine("Xizmatlarimizdan foydalanganingiz uchun rahmat!");
                Console.WriteLine();
            }
            Main(args);
        }
        

    }
}