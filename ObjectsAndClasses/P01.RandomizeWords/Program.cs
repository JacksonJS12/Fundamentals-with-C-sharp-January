using System;

namespace P01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int randomIndex = random.Next(0, words.Length);

                string currentWord = words[i];
                words[i] = words[randomIndex];
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
           
        }
    }
}
