using System;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 0; i < num; i++)
            {
                var currentOddNum = 1 + (i * 2);
                sum += currentOddNum;

                Console.WriteLine(currentOddNum);
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
