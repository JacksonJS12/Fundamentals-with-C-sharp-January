using System;

namespace P01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNum(num1, num2, num3));
        }

        static int SmallestNum(int num1, int num2, int num3)
        {
            int biggestNum = Math.Min(num1, Math.Min(num2, num3));

            return biggestNum;

        }
    }
}
