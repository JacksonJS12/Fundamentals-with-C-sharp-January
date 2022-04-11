using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SpiceShelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> spices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "done")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];
                if (cmdType == "AddSpice")
                {
                    string spice = cmdArgs[1];
                    if (!spices.Contains(spice))
                    {
                        spices.Add(spice);
                    }
                }
                else if (cmdType == "AddManySpices")
                {
                    int index = int.Parse(cmdArgs[1]);
                    string[] spicesToAdd = cmdArgs[2]
                        .Split('|', StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    spices.InsertRange(index, spicesToAdd);


                }
                else if (cmdType == "SwapSpices")
                {
                    string spiceOne = cmdArgs[1];
                    string spiceTwo = cmdArgs[2];

                    int indexOne = spices.IndexOf(spiceOne);
                    int indexTwo = spices.IndexOf(spiceTwo);
                    spices.Insert(indexOne, spiceTwo);
                    spices.RemoveAt(indexOne + 1);

                    spices.Insert(indexTwo, spiceOne);
                    spices.RemoveAt(indexTwo + 1);

                }
                else if (cmdType == "ThrowAwaySpices")
                {
                    string spice = cmdArgs[1];
                    int numberOfSpicesToRemove = int.Parse(cmdArgs[2]);

                    if (spices.Contains(spice))
                    {
                        int index = spices.IndexOf(spice);
                        for (int i = 0; i < numberOfSpicesToRemove; i++)
                        {
                            spices.RemoveAt(index);
                        }

                    }
                }
                else if (cmdType == "Arrange")
                {
                    spices.Sort();
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", spices));
        }
    }
}
