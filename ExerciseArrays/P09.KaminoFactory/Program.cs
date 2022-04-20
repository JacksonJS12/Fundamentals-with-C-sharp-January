using System;
using System.Linq;
namespace Kamino_factory_snd_try
{
    class Program
    {
        static int indexStartOfTheLongestSubsequence(int[] dna)
        {
            int leftMost = int.MinValue;
            int subsequenceMaxInTheArray = 0;
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 1)
                {
                    int subsequence = 1;
                    for (int j = i + 1; j < dna.Length; j++)
                    {
                        if (dna[i] == dna[j])
                            subsequence++;
                        else
                            break;
                    }
                    if (subsequence > subsequenceMaxInTheArray)
                    {
                        subsequenceMaxInTheArray = subsequence;
                        leftMost = i;

                    }

                }
            }
            return leftMost;

        }
        static int Subsequence(int[] dna)
        {
            int subsequenceMaxInTheArray = 0;
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 1)
                {
                    int subsequence = 1;
                    for (int j = i + 1; j < dna.Length; j++)
                    {
                        if (dna[i] == dna[j])
                            subsequence++;
                        else
                            break;
                    }
                    if (subsequence > subsequenceMaxInTheArray)
                    {
                        subsequenceMaxInTheArray = subsequence;


                    }

                }
            }
            return subsequenceMaxInTheArray;
        }

        static int MostOnes(int[] dna)
        {
            int mostOnes = 0;
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 1)
                {
                    mostOnes++;
                }
            }
            return mostOnes;
        }

        static int[] Dna(string entry)
        {
            return entry.Split(new[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

        }
        static void Main()
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string entry = Console.ReadLine();

            int mostLeft = indexStartOfTheLongestSubsequence(Dna(entry));
            int longestSubsequenceOnes = Subsequence(Dna(entry));
            int mostOnes = int.MinValue;
            int sample = 0;
            int bestSample = 0;

            int[] bestDna = new int[dnaLength];

            while (entry != "Clone them!")
            {
                int[] dna = Dna(entry);
                sample++;
                int ones = MostOnes(dna);
                if (longestSubsequenceOnes < Subsequence(dna))
                {
                    longestSubsequenceOnes = Subsequence(dna);
                    bestDna = dna;
                    bestSample = sample;
                    mostOnes = ones;
                }
                else if (longestSubsequenceOnes == Subsequence(dna))
                {
                    int leftMostTry = indexStartOfTheLongestSubsequence(dna);
                    if (mostLeft > leftMostTry)
                    {
                        mostLeft = leftMostTry;
                        bestDna = dna;
                        bestSample = sample;
                        mostOnes = ones;

                    }
                    else if (mostLeft == leftMostTry)
                    {

                        if (mostOnes < ones)
                        {
                            mostOnes = ones;
                            bestDna = dna;
                            bestSample = sample;
                        }
                    }
                }

                entry = Console.ReadLine();

            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {mostOnes}.");
            Console.WriteLine(string.Join(' ', bestDna));
        }
    }
}
