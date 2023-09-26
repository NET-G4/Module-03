using System.Globalization;
using System.Runtime.CompilerServices;

namespace Homework05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please create Password to your account! ");
                Thread.Sleep(500);
                Console.Write("Password:");
                string s = Console.ReadLine();
                Password(s);
                return;

            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine("Sorry your password does not match the requirements \nIn your Password must exist \nMinimum 8 elements \nMinimum 1 number \nMinimum 1 upper shrift \nMinimum 1 lower shrift \nMinimum 1 symbol");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong,Please try again! ");
            }
            Console.WriteLine();
            Thread.Sleep(5000);
            Console.Clear();

            Main(args);
        }

        public static void Password(string s)
        {
            bool NumCounter = false, UpperCounter = false, LowerCounter = false, SymbolCounter = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]))
                {
                    NumCounter = true;
                }
                if (char.IsUpper(s[i]))
                {
                    UpperCounter = true;
                }
                if (char.IsLower(s[i]))
                {
                    LowerCounter = true;
                }
                if (!char.IsDigit(s[i]) && !char.IsLetter(s[i]))
                {
                    SymbolCounter = true;
                }
            }

            if (s.Length >= 8 && NumCounter && UpperCounter && LowerCounter && SymbolCounter)
            {
                Console.WriteLine("Your password has been successfully saved, Congratulations! ");
            }
            else
            {
                throw new InvalidPasswordException("Sorry your password does not match the requirements");
            }
        }
    }
}