using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            double avarageNum = AvarageNumber(input);

            List<int> greaterNumbers = GreaterNumberThanAvarage(input, avarageNum);
            List<int> topFive = new List<int>();



            if (greaterNumbers.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    topFive.Add(greaterNumbers[i]);
                }

                Console.WriteLine(string.Join(" ", topFive));
            }
            else if (greaterNumbers.Count < 5)
            {
                if (greaterNumbers.Count == 1 || greaterNumbers.Count == 0)
                {
                    Console.WriteLine("No");
                    return;
                }

                Console.WriteLine(string.Join(" ", greaterNumbers));


            }
        }
        static double AvarageNumber(int[] input)
        {
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];
            }
            double avarageNum = sum / input.Length;
            return avarageNum;
        }

        static List<int> GreaterNumberThanAvarage(int[] input, double avarageNum)
        {
            List<int> greaterNumbers = new List<int>();
            List<int> topFive = new List<int>();

            for (int index = 0; index < input.Length; index++)
            {
                if (input[index] > avarageNum)
                {
                    greaterNumbers.Add(input[index]);
                }

            }

            greaterNumbers.Sort((a, b) => b.CompareTo(a));
            
            return greaterNumbers;
        }
    }
}
