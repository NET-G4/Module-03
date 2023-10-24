namespace Homework05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Shell we start calculating!");
                Console.Write("Enter first number : ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter action :");
                char action = Console.ReadLine()[0];
                Console.Write("Enter second number : ");
                int secondNumber = int.Parse(Console.ReadLine());
                
                Calculate(firstNumber, secondNumber, action);

            }
            catch (CannotEnterAnotherSymbolException ex)
            {
                Console.WriteLine("Wrong symbol . Please, try again");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong!");
            }
            Thread.Sleep(3000);
            Console.Clear();
            Main(args);
        }

        public static void Calculate(int firstNum,  int secondNum, char action)
        {
            int result;
            
            switch (action)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '/':
                    result = firstNum / secondNum;
                    break;
                default: throw new CannotEnterAnotherSymbolException("Wrong symbol!");
            }
            Console.Clear();
            Console.WriteLine($"{firstNum} {action} {secondNum} = {result}");

        }

    }
}