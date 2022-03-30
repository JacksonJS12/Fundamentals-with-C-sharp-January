using System;

namespace P01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintNumberSigh(number);
        }

        static void PrintNumberSigh(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            else if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative. ");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
