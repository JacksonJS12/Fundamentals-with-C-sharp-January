using System;
using System.Linq;

namespace P08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            decimal sum = 0;

            foreach (string word in words)
            {
                sum += CalculateSingleWordSum(word);
            }
            Console.WriteLine($"{sum:f2}");
        }
        static decimal CalculateSingleWordSum(string word)
        {
            decimal sum = 0;

            char firstLetter = word[0];
            char lastLetter = word[word.Length - 1];
            int num = int.Parse(word.Substring(1, word.Length - 2));

            int firstLetterPos = GetAlphabetPositionOfCharacter(firstLetter);
            int lastLetterPos = GetAlphabetPositionOfCharacter(lastLetter);

            if (firstLetterPos == -1 || lastLetter == -1)
            {
                return 0m;
            }

            if (Char.IsUpper(firstLetter))
            {
                sum = (decimal)num / firstLetterPos;
            }
            else if (Char.IsLower(firstLetter))
            {
                sum = (decimal)num * firstLetterPos;
            }

            if (Char.IsUpper(lastLetter))
            {
                sum -= lastLetterPos;
            }
            else if (Char.IsLower(lastLetter))
            {
                sum += lastLetterPos;


            }
            return sum;


            static int GetAlphabetPositionOfCharacter(char ch)
            {
                if (!Char.IsLetter(ch))
                {
                    return -1;
                }

                char chCI = char.ToLowerInvariant(ch);

                return (int)chCI - 96;
            }
        }
    }
}