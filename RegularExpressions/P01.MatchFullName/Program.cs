using System;
using System.Text.RegularExpressions;

namespace P01.MatchFullName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b([A-Z][a-z]{1,}) ([A-Z][a-z]{1,})\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, patern);

            foreach (Match item in matches)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();

        }
    }
}
