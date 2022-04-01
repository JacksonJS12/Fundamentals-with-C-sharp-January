using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.ListManipulationAdvanced
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
            bool hasChanges = false;

            while (command != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                if (action == "Add")
                {
                    int numberToAdd = int.Parse(token[1]);
                    numbers.Add(numberToAdd);
                    hasChanges = true;
                }
                else if (action == "Remove")
                {
                    int numberToRemove = int.Parse(token[1]);
                    numbers.Remove(numberToRemove);
                    hasChanges = true;
                }
                else if (action == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(token[1]);
                    numbers.RemoveAt(numberToRemoveAt);
                    hasChanges = true;
                }
                else if (action == "Insert")
                {
                    int indexToInsertAt = int.Parse(token[2]);
                    int elementToInsertAt = int.Parse(token[1]);
                    numbers.Insert(indexToInsertAt, elementToInsertAt);
                    hasChanges = true;
                }

                else if (action == "Contains")
                {
                    int elementToCheck = int.Parse(token[1]);
                    if (numbers.Contains(elementToCheck))
                    {
                        Console.WriteLine("Yes");
                    } 
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (action == "PrintEven")
                {
                    List<int> evenNumbers = numbers.FindAll(x => x % 2 == 0);
                    Console.WriteLine(string.Join(" ", evenNumbers));
                }
                else if (action == "PrintOdd")
                {
                    List<int> oddNumbers = numbers.FindAll(x => x % 2 != 0);
                    Console.WriteLine(string.Join(" ", oddNumbers));
                }
                else if (action == "GetSum")
                {
                    int sum = numbers.Sum();
                    Console.WriteLine(sum);
                }
                else if (action == "Filter")
                {
                    string condition = token[1];
                    int numberForComparison = int.Parse(token[2]);
                    List<int> result = GetFilteredNumbers(numbers, condition, numberForComparison);
                    Console.WriteLine(string.Join(" ", result));
                }

                command = Console.ReadLine();
            }
            if (hasChanges)
            {

            Console.WriteLine(String.Join(" ", numbers));
            }
        }

        static List<int> GetFilteredNumbers(List<int> allNumbers, string condition, int numberToCompare)
        {
            if (condition == "<")
            {
                List<int> result = allNumbers.FindAll(x => x < numberToCompare);
                return result; 
            }
            else if (condition == ">")
            {
                List<int> result = allNumbers.FindAll(x => x > numberToCompare);
                return result;

            }
            else if (condition == "<=")
            {
                List<int> result = allNumbers.FindAll(x => x <= numberToCompare);
                return result;
            }
            else if (condition == ">=")
            {
                List<int> result = allNumbers.FindAll(x => x >= numberToCompare);
                return result;
            }
            else
            {
                return allNumbers;
            }
        }
    }
}
