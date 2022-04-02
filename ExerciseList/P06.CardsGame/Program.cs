using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondHand = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

         


            while (true)
            {

                if (firstHand[0] > secondHand[0])

                {
                    firstHand.Add(firstHand[0]);
                    firstHand.Add(secondHand[0]);

                }

                else if (firstHand[0] < secondHand[0])
                {
                    secondHand.Add(secondHand[0]);
                    secondHand.Add(firstHand[0]);
                }

                firstHand.RemoveAt(0);
                secondHand.RemoveAt(0);

                if (firstHand.Count == 0)
                {
                    int sumOfCardsFirstHand = secondHand.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sumOfCardsFirstHand}");
                    break;
                }
                else if (secondHand.Count == 0)
                {
                    int sumOfCardsSecondHand = firstHand.Sum();
                    Console.WriteLine($"First player wins! Sum: {sumOfCardsSecondHand}");
                    break;
                }

            }




        }
    }
}
