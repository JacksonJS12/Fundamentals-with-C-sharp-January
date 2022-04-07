using System;

namespace P01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            
            while (command != "end")
            {
                string word = command;
                
                Console.WriteLine($"{word} = {ReverseString(word)}");
                command = Console.ReadLine();
            }
        }

        static string ReverseString(string word)
        {
            char[] chars = word.ToCharArray();
            string reverse = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }
            return reverse;
        }
    }
}
