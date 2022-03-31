using System;
using System.Linq;

namespace P02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int vowelsCount = GetVowelsCount(word);

            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCount(string word)
        {
            char[] vowels = new char[]
            {
                'a',
                'e',
                'i',
                'o',
                'u'
            };
            int vowelsCount = 0;
            foreach (char ch in word.ToLower())
            {
                if (vowels.Contains(ch))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
