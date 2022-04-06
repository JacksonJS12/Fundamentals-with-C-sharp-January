using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] keyMaterialsNames = new string[]
            {
                "shards",
                "fragments",
                 "motes"
            };

            Dictionary<string, int> keyMaterial = new Dictionary<string, int>()
            {
                { "shards", 0},
                { "motes", 0},
                { "fragments", 0}
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();

            string itemObtained = string.Empty;

            while (String.IsNullOrEmpty(itemObtained))
            {
                string materialsLine = Console.ReadLine().ToLower();
                string[] materialsArray = materialsLine
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                ProcessInputLine(keyMaterial, junk, materialsArray, ref itemObtained);
            }
            PrintOutput(keyMaterial, junk, itemObtained);
        }



        static void ProcessInputLine(Dictionary<string, int> keyMaterials, Dictionary<string, int> junk,
            string[] materialsArray, ref string itemObtained)
        {
            const int minCraftMaterialQty = 250;
            Dictionary<string, string> craftingTable = new Dictionary<string, string>()
            {
                { "shards", "Shadowmourne " },
                { "motes", "Dragonwrath "},
                {"fragments",  "Valanyr "}
            };
            for (int i = 0; i < materialsArray.Length; i += 2)
            {
                int currentMaterialQly = int.Parse(materialsArray[i]);
                string currentMaterial = materialsArray[i + 1];
                if (keyMaterials.ContainsKey(currentMaterial))
                {
                    keyMaterials[currentMaterial] += currentMaterialQly;

                    if (keyMaterials[currentMaterial] >= minCraftMaterialQty)
                    {
                        itemObtained = craftingTable[currentMaterial];
                        keyMaterials[currentMaterial] -= minCraftMaterialQty;

                        break;
                    }
                }
                else
                {
                    if (!junk.ContainsKey(currentMaterial))
                    {
                        junk[currentMaterial] = 0;
                    }
                    junk[currentMaterial] += currentMaterialQly;
                }
            }

        }

        static void PrintOutput(Dictionary<string, int> keyMaterialsLeft,
            Dictionary<string, int> junk, string itemObtaied)
        {
            Console.WriteLine($"{itemObtaied}obtained!");
            foreach (var kvp in keyMaterialsLeft)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }



    }
}
