using System;

namespace P11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Result(firstNum, secondNum, @operator);
        }

        static int Result(int firstNum, int secondNum, char @operator)
        {
            int result = 0;

            if (@operator == '+')
            {
                result = firstNum + secondNum;
            }
            else if (@operator == '/')
            {
                result = firstNum / secondNum;
            }
            else if (@operator == '-')
            {
                result = firstNum - secondNum;
            }
            else if (@operator == '*')
            {
                result = firstNum * secondNum;
            }

            Console.WriteLine(result);
            return result;

        }
    }
}
