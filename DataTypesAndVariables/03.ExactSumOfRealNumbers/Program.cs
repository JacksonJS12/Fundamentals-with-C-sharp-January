using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 1; i <= num; i++)
            {
                sum += decimal.Parse(Console.ReadLine());
            }
            Console.WriteLine($"{sum}");
            
        }
    }
}
