using System;

namespace MoreExerciseP03.RecursiveFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            int[] fibonacciSequence = new int[50];

            fibonacciSequence[0] = 1;
            fibonacciSequence[1] = 1;

            if (position > 2)
            {
                for (int i = 2; i < position; i++)
                {
                    fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
                }
            }
            Console.WriteLine(fibonacciSequence[position - 1]);
        }
    }
}
