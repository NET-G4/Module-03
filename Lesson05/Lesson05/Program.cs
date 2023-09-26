using System.IO;
using System.Net;

namespace Lesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception error = null;
            try
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());

                int result = Calculate(firstNumber, secondNumber);

                Console.WriteLine($"Your result: {result}");
            }
            catch (CannotEnterFiveException ex)
            {
                error = ex;
                Console.WriteLine("Five cannot be entered. Please, enter another number.");
            }
            catch (ArgumentException ex)
            {
                error = ex;
            }
            catch (DivideByZeroException ex)
            {
                error = ex;
                Console.WriteLine("You cannot divide by 0.");
            }
            catch(FormatException ex)
            {
                error = ex;
                Console.WriteLine("Incorrect number format.");
            }
            catch (Exception ex)
            {
                error = ex;
                Console.WriteLine("Something went wrong. Please, try again.");
            }
            finally
            {
                if (error != null)
                {
                    LogError(error);
                }
            }

            Main(args);
        }

        public static void LogError(Exception ex)
        {
            FileInfo fileInfo = new FileInfo("../../../errors.txt");
            try
            {
                File.WriteAllText(fileInfo.FullName, ex.Message);
            }
            finally
            {
                
            }
        }

        public static int Calculate(int firstNumber, int secondNumber)
        {
            int result = Display(firstNumber, secondNumber);
            Console.WriteLine("Calculate finished");
            return result;
        }

        public static int Display(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} / {secondNumber}");
            int result = Divide(firstNumber, secondNumber);
            Console.WriteLine("Display finished");
            return result;
        }

        public static int Divide(int firstNumber, int secondNumber)
        {
            if (firstNumber == 5 || secondNumber == 5)
            {
                throw new CannotEnterFiveException("Five cannot be entered.");
            }
            int result = firstNumber / secondNumber;
            Console.WriteLine("Divide finished");
            return result;
        }
    }
}