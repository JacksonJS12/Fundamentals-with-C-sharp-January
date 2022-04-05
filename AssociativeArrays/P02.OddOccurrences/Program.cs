using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> occurencies = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string loweCaseWord = word.ToLower();

                if (occurencies.ContainsKey(loweCaseWord))
                {
                    occurencies[loweCaseWord] += 1;
                }
                else
                {
                    occurencies.Add(loweCaseWord, 1);
                }
            }
           string[] result = occurencies.Where(item => item.Value % 2 != 0)
                .Select(item => item.Key)
                .ToArray();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
