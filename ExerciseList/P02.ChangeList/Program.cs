using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] commandArgs = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandType = commandArgs[0];
                string element = commandArgs[1];

                if (commandType == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(element));
                }

                if (commandType == "Insert")
                {
                    string position = commandArgs[2];
                    numbers.Insert(int.Parse(position), int.Parse(element));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
