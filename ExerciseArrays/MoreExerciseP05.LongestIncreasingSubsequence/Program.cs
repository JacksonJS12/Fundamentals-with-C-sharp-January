using System;
using System.Linq;

namespace MoreExerciseP05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] len = Array.Empty<int>();
            for (int p = 0; p < numbers.Length; p++)
            {

            }

        }
    }
}
