using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Max_SequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            { 
            Console.WriteLine(string.Join(" ", numbers.Where(x => numbers[i] == numbers[i + 1])));
            }
        }
    }
}
