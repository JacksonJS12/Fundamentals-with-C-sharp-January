using System;

namespace MoreExerciseP03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[] sequences = new int[input];
            int lastNum = 0;
            for (int i = 0; i < input; i++)
            {
                if (i == 0)
                {
                    sequences[0] = 1;
                    lastNum = 1;
                    continue;
                }

                sequences[i] = i + lastNum;
                lastNum = i;
            }

            Console.WriteLine(string.Join(" ", sequences));
        }
    }
}
