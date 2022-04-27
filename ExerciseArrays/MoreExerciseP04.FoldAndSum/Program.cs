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



            int[] firstPart = FirstPart(input);
            int[] secondPart = SecondPart(input);

            int[] firstRow = FirstRow(input, firstPart, secondPart);
            int[] secondRow = SecondRow(input, firstPart, secondPart, firstRow);




            int[] result = new int[firstRow.Length];
            for (int i = 0; i < firstRow.Length; i++)
            {
                result[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
        static int[] FirstPart(int[] input)
        {
            int[] firstPart = new int[input.Length / 4];
            for (int i = 0; i < input.Length / 4; i++)
            {
                firstPart[i] = input[i];
            }
            Array.Reverse(firstPart);

            return firstPart;
        }

        static int[] SecondPart(int[] input)
        {
            int[] secondPart = Array.Empty<int>().ToArray();
            for (int i = input.Length - 1; i > input.Length - 1 - (input.Length / 4); i--)
            {
                secondPart = secondPart.Append(input[i]).ToArray();
            }

            return secondPart;
        }

        static int[] FirstRow(int[] input, int[] firstPart, int[] secondPart)
        {

            int[] firstRow = firstPart.Concat(secondPart).ToArray();


            return firstRow;
        }

        static int[] SecondRow(int[] input, int[] firstPart, int[] secondPart, int[] firstRow)
        {
            int[] secondRow = Array.Empty<int>();


            for (int i = 0; i < firstRow.Length; i++)
            {
             bool flag = input.Contains(firstRow[i]);
                if (flag == true)
                {
                    input = input.Where(val => val != firstRow[i]).ToArray();
                }

            }

            secondRow = input;
            return secondRow;
        }
    }

}
