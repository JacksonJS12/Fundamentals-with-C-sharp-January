using System;
using System.Linq;

namespace P02.Jeweler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] whiteGold = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] yellowGold = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int pairs = 0;
            int leftoverGold = 0;

            for (int i = 0; i < whiteGold.Length; i++)
            {

                if (whiteGold[i] + yellowGold[i] == 10)
                {
                    pairs++;
                }
                else if (whiteGold[i] + yellowGold[i] > 10)
                {
                    while (whiteGold[i] + yellowGold[i] > 10)
                    {
                        yellowGold[i] -= 2;

                    }

                    if (whiteGold[i] + yellowGold[i] == 10)
                    {
                        pairs++;
                    }
                    else if (whiteGold[i] + yellowGold[i] < 10)
                    {
                        leftoverGold += whiteGold[i] + yellowGold[i];
                    }
                }
                else if (whiteGold[i] + yellowGold[i] < 10)
                {
                    leftoverGold += whiteGold[i] + yellowGold[i];
                }

            }
            if (leftoverGold / 10 > 0)
            {
                pairs += leftoverGold / 10;
                
            }
            if (pairs >= 7)
            {
                Console.WriteLine($"Great success, you created {pairs} earrings.");
            }
            else
            {
                Console.WriteLine($"Keep trying, you need {7 - pairs} more earrings.");
            }
        }
    }
}
