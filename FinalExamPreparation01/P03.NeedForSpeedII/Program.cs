using System;
using System.Collections.Generic;

namespace P03.Pirates
{
    class City
    {
        public City(string name, int population, int gold)
        {
            this.Name = name;
            this.Population = population;
            this.Gold = gold;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstCommand = Console.ReadLine();
            Dictionary<string, City> cities = new Dictionary<string, City>();
            while (firstCommand != "Sail")
            {
                string[] cmdArgs = firstCommand
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);

                string cityName = cmdArgs[0];
                int population = int.Parse(cmdArgs[1]);
                int gold = int.Parse(cmdArgs[2]);


                if (cities.ContainsKey(cityName))
                {
                    cities[cityName].Population += population;
                    cities[cityName].Gold += gold;
                }
                else
                {
                    City newCity = new City(cityName, population, gold);
                    cities.Add(cityName, newCity);
                }


                firstCommand = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand != "End")
            {
                string[] cmdArgs = secondCommand
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string cmdType = cmdArgs[0];
               

                if (cmdType == "Plunder")
                {
                    string townToPlunder = cmdArgs[1];
                    int peopleToRemove = int.Parse(cmdArgs[2]);
                    int goldToSteal = int.Parse(cmdArgs[3]);

                    cities[townToPlunder].Population -= peopleToRemove;
                    cities[townToPlunder].Gold -= goldToSteal;

                    Console.WriteLine($"{townToPlunder} plundered! {goldToSteal} gold stolen, {peopleToRemove} citizens killed.");

                    if (cities[townToPlunder].Population <= 0 || cities[townToPlunder].Gold <= 0)
                    {
                        Console.WriteLine($"{townToPlunder} has been wiped off the map!");
                        cities.Remove(townToPlunder);
                    }

                }
                else if (cmdType == "Prosper")
                {
                    string townToProsper = cmdArgs[1];
                    int goldToAdd = int.Parse(cmdArgs[2]);

                    if (goldToAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        secondCommand = Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        cities[townToProsper].Gold += goldToAdd;
                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. {townToProsper} now has {cities[townToProsper].Gold} gold.");
                    }
                }

                secondCommand = Console.ReadLine();
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");

            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (KeyValuePair<string, City> city in cities)
                {
                    City currentCity = city.Value;

                    Console.WriteLine($"{ currentCity.Name} -> Population: {currentCity.Population} citizens, Gold: {currentCity.Gold} kg");
                }
            }
        }
    }
}
