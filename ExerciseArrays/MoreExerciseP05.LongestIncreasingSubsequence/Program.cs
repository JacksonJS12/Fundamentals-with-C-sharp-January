using System;
using System.Linq;

namespace MoreExerciseP05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] lis = new int[input.Length];
            int lastNum = 0;
            int prevNum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    lis[0] = input[0];
                    lastNum = input[0];
                    prevNum = input[0];
                    continue;
                }

                if (lastNum < input[i])
                {
                    lis[i] = input[i];
                    lastNum = input[i];
                    prevNum = input[i - 1];
                }
                else if(prevNum < input[i] && lastNum > input[i])
                {
                    lis[i-1] = input[i];
                    lastNum = input[i];
                    prevNum = input[i - 1];
                    
                }

            }
        }
    }
}
