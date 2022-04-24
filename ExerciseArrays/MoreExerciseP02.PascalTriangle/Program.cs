using System;
using System.Linq;

namespace MoreExerciseP02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] currRow = new int[rows];
            int[] lastRow = new int[rows];

            for (int row = 0; row < rows; row++)
            {
                lastRow = currRow;

                currRow = new int[row + 1];

                for (int i = 0; i < currRow.Length; i++)
                {
                    if (!(i == 0))
                    {
                        if (lastRow.Length > 1)
                        {
                            if (!(i == lastRow.Length))
                            {
                                currRow[i] = lastRow[i] + lastRow[i - 1];

                            }
                            else
                            {
                                currRow[i] = 1;
                            }
                        }
                        else
                        {
                            currRow[i] = 1;
                        }
                    }
                    else
                    {
                        currRow[i] = 1;
                    }

                }

                Console.WriteLine(string.Join(" ", currRow));
            }
        }
    }
}
