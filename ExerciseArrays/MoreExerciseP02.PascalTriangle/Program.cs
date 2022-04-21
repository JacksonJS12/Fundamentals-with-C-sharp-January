using System;
using System.Linq;

namespace MoreExerciseP02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int row = 1; row <= rows; row++)
            {
                int[] thisRow = new int[row];

                for (int i = 0; i < thisRow.Length; i++)
                {
                    if (row != 1)
                    {
                        thisRow[i] = thisRow[i] + 
                    }
                }




                int[] latRow = thisRow;
            }
        }
    }
}
