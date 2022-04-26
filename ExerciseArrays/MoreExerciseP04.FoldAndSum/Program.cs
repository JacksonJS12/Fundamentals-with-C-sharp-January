using System;
using System.Linq;

namespace MoreExerciseP04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] firstRow = new int[input.Length / 2];
            int[] secondRow = new int[input.Length / 2];

            int[] result = new int[firstRow.Length];

            int[] firstPart = new int[input.Length / 4];
            for (int i = 0; i < firstRow.Length / 2; i++)
            {
                firstPart.Append(input[i]);
            }
            firstPart.Reverse();
            for (int i = 0; i < firstPart.Length; i++)
            {
                firstRow.Append(firstPart[i]);
            }
            int[] secondPart = new int[input.Length / 4];
            for (int i = input.Length - 1; i >= input.Length / 4; i--)
            {
                secondPart.Append(input[i]);
            }
            secondPart.Reverse();

            for (int i = 0; i < secondPart.Length; i++)
            {
                firstRow.Append(secondPart[i]);
            }


            for (int i = 0; i < firstRow.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
       
    }
    
}
