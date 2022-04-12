using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.DestinationMapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> destinations = new List<string>();
            int travelPoint = 0;
            string pattern = @"(\=|\/)(?<destination>[A-Z][A-Za-z]{2,})(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern); //all matches of this pattern


            foreach (Match currMatch in matches)
            {
                string currDestination = currMatch.Groups["destination"].Value;
                    destinations.Add(currDestination);
                travelPoint += currDestination.Length;

            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoint}");

        }
    }
}
 