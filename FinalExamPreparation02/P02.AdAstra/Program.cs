using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            string pattern = @"(\#|\|)(?<name>[A-Za-z]{1,}( |)[A-Za-z]{1,})\1(?<date>(\d{2})\/(\d{2})\/(\d{2}))\1(?<calorie>\d{0,10000})\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            int calorieSum = 0;
            double foodFor = 0;
            foreach (Match match in matches)
            {
                int nutrition = int.Parse(match.Groups["calorie"].Value);

                calorieSum += nutrition;
            }

            foodFor = calorieSum / 2000;
            Console.WriteLine($"You have food to last you for: {Math.Floor(foodFor)} days!");

            foreach (Match match in matches)
            {
                string item = match.Groups["name"].Value;
                string date = match.Groups["date"].Value;
                int nutrition = int.Parse(match.Groups["calorie"].Value);

                Console.WriteLine($"Item: {item}, Best before: {date}, Nutrition: {nutrition}");

         
            }
           
        }
    }
}
