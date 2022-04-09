using System;
using System.Text.RegularExpressions;

namespace P03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})(\.|-|\/)([A-Z][a-z]{2})\2(\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                //Day: 13, Month: Jul, Year: 1928
                string day = match.Groups[1].Value; 
                string month = match.Groups[3].Value;
                string year = match.Groups[4].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
