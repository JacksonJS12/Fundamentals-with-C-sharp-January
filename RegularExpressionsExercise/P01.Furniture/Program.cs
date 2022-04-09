using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> furnitureBough = new List<string>();
            decimal totalMoneySpend = 0;
            string pattern = @"[>]{2}(?<name>[A-Za-z]+)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";

            while (input != "Purchase")
            {
                Match furnitureInfo = Regex.Match(input, pattern);

                if (furnitureInfo.Success)
                {
                    string furnitureName = furnitureInfo.Groups["name"].Value;
                    decimal price = decimal.Parse(furnitureInfo.Groups["price"].Value);
                    int quantity = int.Parse(furnitureInfo.Groups["quantity"].Value);

                    furnitureBough.Add(furnitureName);
                    totalMoneySpend += price * quantity;
                }

                input = Console.ReadLine();
            }
            PrintOutput(furnitureBough, totalMoneySpend);
        }
        static void PrintOutput(List<string> furnitures, decimal moneySpend)
        {
            Console.WriteLine("Bought furniture:");

            foreach (string furnitureName in furnitures)
            {
                Console.WriteLine(furnitureName);
            }
            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
