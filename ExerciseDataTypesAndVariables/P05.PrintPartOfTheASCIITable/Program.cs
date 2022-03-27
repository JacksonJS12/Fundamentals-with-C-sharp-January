using System;

namespace _05._Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());

            for (int currIndex = startIndex; currIndex <= endIndex; currIndex++)
            {
                char currCh = (char)currIndex;

                Console.Write($"{currCh} ");
            }
            
        }
    }
}
