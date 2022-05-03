using System;
using System.Linq;

namespace MoreExerciseP05.LongestIncreasingSubsequence
{
    class Program
    {
        public static void Main()
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int[] lis;
            int[] len = new int[sequence.Length];
            int[] prev = new int[sequence.Length];
            int maxLength = 0;
            int lastIndex = -1;

            // tour the sequence
            for (int i = 0; i < sequence.Length; i++)
            {
                // length && previous respectively = 1 && -1
                len[i] = 1;
                prev[i] = -1;

                //compare the sequence for best length of the sequence 
                // if i == j -> loop j won't fulfill
                for (int j = 0; j < i; j++)
                {
                    
                    // current count of elements j >= elements count of i -> elements count /sequence/ will increase
                    
                    if (sequence[j] < sequence[i] && len[j] >= len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j; //save the index of the best element of the sequence
                    }
                }
                //save max count of elements
                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }
            lis = new int[maxLength];
            for (int i = 0; i < maxLength; i++)
            {
                lis[i] = sequence[lastIndex];
                lastIndex = prev[lastIndex];
            }
            Array.Reverse(lis);
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
