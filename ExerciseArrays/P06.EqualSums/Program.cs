using System;
using System.Linq;

namespace _06.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ia = Console.ReadLine()
                .Split(' ')
                .Where(x => x.Length > 0)
                .Select(int.Parse)
                .ToArray();

            int[] LeftToRightSum = new int[ia.Length];
            int[] RightToLeftSum = new int[ia.Length];

            int T = 0;

            for (int i = 0; i < ia.Length; i++)
            {
                T += ia[i];
                LeftToRightSum[i] = T;
            }

            T = 0;

            for (int i = ia.Length - 1; i >= 0; i--)
            {
                T += ia[i];
                RightToLeftSum[i] = T;
            }

            int ix = -1;

            for (int i = 0; i < ia.Length; i++)
            {
                if (LeftToRightSum[i] == RightToLeftSum[i])
                {
                    ix = i;
                    break;
                }
            }

            if (ix < 0)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(ix);
            }
        }
    }
}
