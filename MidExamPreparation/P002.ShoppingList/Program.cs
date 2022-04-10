using System;
using System.Collections.Generic;
using System.Linq;

namespace P002.ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> groceries = Console.ReadLine()
                .Split('!', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            while (command != "Go Shopping!")
            {
                string[] cmdArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string cmdType = cmdArgs[0];
                if (cmdType == "Urgent")
                {
                    string item = cmdArgs[1];

                    if (!groceries.Contains(item))
                    {
                        groceries.Insert(0, item);
                    }

                }
                else if (cmdType == "Unnecessary")
                {
                    string item = cmdArgs[1];

                    if (groceries.Contains(item))
                    {
                        groceries.Remove(item);
                    }
                }
                else if (cmdType == "Correct")
                {
                    string oldItem = cmdArgs[1];
                    string newItem = cmdArgs[2];

                    if (groceries.Contains(oldItem))
                    {
                        groceries.Insert(groceries.IndexOf(oldItem), newItem);
                        groceries.RemoveAt(groceries.IndexOf(oldItem));
                    }
                }
                else if (cmdType == "Rearrange")
                {
                    string item = cmdArgs[1];

                    if (groceries.Contains(item))
                    {
                        int index = groceries.IndexOf(item);
                        groceries.RemoveAt(index);
                        groceries.Add(item);
                    }

                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
