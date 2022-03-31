using System;

namespace P05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int tirthNum = int.Parse(Console.ReadLine());

            TotalSum(firstNum, secondNum, tirthNum);
        }

        static int IntegerGathering(int firstNum, int secondNum)
        {
           int firstPlusSecond = firstNum + secondNum;

            return firstPlusSecond;
        }

        static void TotalSum(int firstNum, int secondNum, int tirthNum)
        {
            Console.WriteLine(IntegerGathering(firstNum, secondNum) - tirthNum);
        }
    }
}
