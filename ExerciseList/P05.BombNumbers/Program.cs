using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bombNum = bombInfo[0];
            int bombPower = bombInfo[1];

            //int indexOfBomb;
            //while ((indexOfBomb = numbers.IndexOf(bombNum)) >= 0)
            //{

            //}

            while (true)
            {
                int indexOfBomb = numbers.IndexOf(bombNum);

                if (indexOfBomb == -1)
                {
                    break;
                }
                DetonateBomb(numbers, indexOfBomb, bombPower);
            }
            Console.WriteLine(numbers.Sum());
            
        }

        static void DetonateBomb(List<int> numbers, int indexOfBomb, int bombPower)
        {
            int rightIndex = indexOfBomb + bombPower;
            for (int counter = indexOfBomb; counter <= rightIndex; counter++)
            {
                if (indexOfBomb >= numbers.Count)
                {
                    break;
                }

                numbers.RemoveAt(indexOfBomb);
            }

            int leftCount = indexOfBomb - bombPower;
            if (leftCount < 0)
            {
                leftCount = 0;
            }
            for (int cnt = leftCount; cnt < indexOfBomb; cnt++)
            {
                if (leftCount >= numbers.Count)
                {
                    break;
                }
                numbers.RemoveAt(leftCount);
            }
        }
    }
}
