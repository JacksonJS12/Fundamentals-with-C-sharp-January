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


            int firstRowLeftIndex = input.Length / 4 - 1;
            int firstRowRightIndex = 3 * input.Length / 4;
            
            int[] firstRow = new int[input.Length / 2];

            int numbers = 0;
            for (int i = firstRowLeftIndex; i >= 0; i--)
            {
                numbers++;
                firstRow[firstRowLeftIndex - i] = input[i];
            }

            for (int i = input.Length - 1; i >= firstRowRightIndex; i--)
            {
                firstRow[input.Length - 1 - i + numbers] = input[i];
            }

            int[] secondRow = new int[input.Length / 2];
            for (int i = firstRowLeftIndex + 1; i < firstRowRightIndex; i++)
            {
                secondRow[i - numbers] = input[i];
            }

            for (int i = 0; i < firstRow.Length; i++)
            {
                Console.Write($"{firstRow[i] + secondRow[i]} ");
            }
        }
    }

}
