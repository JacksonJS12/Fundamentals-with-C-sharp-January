using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int[] secondArray = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            int sum = 0;
            bool arraysAreDiffrent = false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += secondArray[i];
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    arraysAreDiffrent = true;
                    return;
                    
                }
            }
            if (!arraysAreDiffrent)
            {
            Console.WriteLine($"Arrays are identical. Sum: {sum}");

            }
        }
    }
}
