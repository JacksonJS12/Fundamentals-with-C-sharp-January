using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int row = 1; row <= n; row++)
            {
                int[] currentRowData = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNum = currentRowData[0];
                int secondNum = currentRowData[1];

                if (row % 2 != 0)
                {
                    //odd row
                    arr1[row - 1] = firstNum;
                    arr2[row - 1] = secondNum;
                }
                else
                {
                    //even row
                    arr1[row - 1] = secondNum;
                    arr2[row - 1] = firstNum;
                }
            }    
                Console.WriteLine(String.Join(" ", arr1));
                Console.WriteLine(String.Join(" ", arr2));

        }
    }
}
