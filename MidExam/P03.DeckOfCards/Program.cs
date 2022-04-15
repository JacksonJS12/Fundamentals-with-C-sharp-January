using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<String> cards = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i <= numberOfCommands; i++)
            {
                string[] commandType = new string[2];

                commandType = Console.ReadLine()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                bool isValid = cards.Any(x => x == commandType[1]);
                int index = cards.FindIndex(a => a == commandType[1]);

                if (commandType[0] == "Add")
                {
                    if (!isValid)
                    {
                        cards.Add(commandType[1]);
                        Console.WriteLine("Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine("Card is already in the deck");
                    }
                }

                if (commandType[0] == "Remove")
                {
                    if (!isValid)
                    {
                        cards.Remove(commandType[1]);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }
                }
                if (commandType[0] == "Remove At")
                {
                    if (isValid)
                    {
                        cards.RemoveAt(int.Parse(commandType[1]));
                        Console.WriteLine("Card successfully removed");
                    }

                    else
                    {
                        Console.WriteLine("Index out of range");
                    }

                }

                if (commandType[0] == "Insert")
                {
                    if (!isValid)
                    {
                        if (cards.ElementAt(int.Parse(commandType[1])) != null)
                        {
                            cards.Insert(int.Parse(commandType[1]), commandType[2]);
                            Console.WriteLine("Card successfully added");
                        }
                        else if(cards.ElementAt(int.Parse(commandType[1])) == null)
                        {
                            Console.WriteLine("Index out of range");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Card is already added");
                    }
                }



            }
        }
    }
}
