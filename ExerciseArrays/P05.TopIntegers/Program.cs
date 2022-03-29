using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //WORST CASE -> ALL INTEGERS WILL BE TOP INTEGERS
            int[] topIntegers = new int[arr.Length];
            int topIntegersIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                bool isTopInteger = true;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];

                    if (nextNum >= currentNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topIntegers[topIntegersIndex] = currentNum;
                    topIntegersIndex++;
                }
            }

            for (int i = 0; i < topIntegersIndex; i++)
            {
                int currentTopInteger = topIntegers[i];
                Console.Write($"{currentTopInteger} ");
            }

        }
    }
}
