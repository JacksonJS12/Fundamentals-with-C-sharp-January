using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!([A-Z][a-z]{3,})!:\[([A-Za-z]{8,})\]";

            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    string command = match.Groups[1].Value;
                    string number = match.Groups[2].Value;

                    Console.Write($"{command}: ");
                    foreach (var c in number)
                    {
                        Console.Write($"{(int)c} ");
                    }
                    Console.WriteLine();
                }
                
            }
        }
    }
}
