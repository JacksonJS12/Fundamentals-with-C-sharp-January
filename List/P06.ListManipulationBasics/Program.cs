using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();    

            while(command != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                }
                else if (action == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(token[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                }
                else if (action == "Insert")
                {
                    int indexToInsertAt = int.Parse(token[2]);
                    int elementToInsertAt = int.Parse(token[1]);
                    numbers.Insert(indexToInsertAt, elementToInsertAt);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
