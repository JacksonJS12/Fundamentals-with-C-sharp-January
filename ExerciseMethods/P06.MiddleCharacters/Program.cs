using System;

namespace P06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleCharecter(input);
        }

        static void MiddleCharecter(string input)
        {
            int length = input.Length;
            if (length % 2 != 0)
            {
                Console.WriteLine(input[length/2]);
            }
            else
            {
                length = length / 2;
                Console.WriteLine(input.Substring((length) - 1, 2));
              
            }
        }
    }
}
