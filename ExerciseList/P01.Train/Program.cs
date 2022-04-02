using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            int maxCapacityPerWagon = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int passengers = 0;

            while (command != "end")
            {
                string[] commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (commandArgs.Length == 1)
                {
                    passengers = int.Parse(commandArgs[0]);

                    for (int wagon = 0; wagon < wagons.Count; wagon++)
                    {

                        if ((wagons[wagon] + passengers) <= maxCapacityPerWagon)
                        {
                            wagons[wagon] += passengers;
                            break;
                        
                        }
                        


                    }

                }
                else if (commandArgs.Length == 2)
                {
                    string commandType = commandArgs[0];
                    passengers = int.Parse(commandArgs[1]);
                    if (commandType == "Add")
                    {
                        wagons.Add(passengers);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
