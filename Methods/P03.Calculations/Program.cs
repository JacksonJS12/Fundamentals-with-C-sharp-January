using System;

namespace P03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (action == "add")
            {
                ActionAdd(num1, num2);
            }
            else if (action == "multiply")
            {
                ActionMultiply(num1, num2);
            }
            else if (action == "subtract")
            {
                ActionSubtract(num1, num2);
            }
            else if (action == "divide")
            {
                ActionDivide(num1, num2);
            }
        }

        static void ActionAdd(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine(result);

        }
        static void ActionMultiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine(result);

        }
        static void ActionSubtract(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine(result);

        }
        static void ActionDivide(int num1, int num2)
        {
            double result = (double)num1 / num2;
            Console.WriteLine(result);
        }
    }
}

