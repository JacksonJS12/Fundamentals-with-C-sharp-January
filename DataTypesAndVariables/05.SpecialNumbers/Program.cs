using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int numToProcess = i;
                int sum = 0;

                while (numToProcess != 0)
                {
                    int currentDigit = numToProcess % 10;
                    numToProcess /= 10;
                    sum += currentDigit;
                }
                bool isSpecial = sum == 5  || sum == 7 || sum == 11 ;

                

                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
