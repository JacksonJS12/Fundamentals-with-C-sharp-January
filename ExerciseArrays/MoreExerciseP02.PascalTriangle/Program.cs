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
                            if (i % 2 == 0 && !(i == currRow.Length - 1))
                            {
                                if (!(lastRow.Length < i + 2))
                                {
                                    currRow[i] = lastRow[i] + lastRow[i + 1];
                                }
                                else
                                {
                                    currRow[i] = lastRow[i] + lastRow[lastRow.Length - 2];
                                }
                            }
                            else if (i % 2 != 0 && !(i == currRow.Length - 1))
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
