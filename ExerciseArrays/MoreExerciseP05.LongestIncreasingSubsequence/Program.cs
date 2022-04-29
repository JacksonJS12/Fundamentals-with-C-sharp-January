using System;
using System.Linq;

namespace MoreExerciseP05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lis = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int length = lis.Length;
            int numbers = 0;
            int previos = lis.Length - 1;
            for (int p = 0; p < lis.Length; p++)
            {
                numbers = lis[p];
            }

        }
    }
}
