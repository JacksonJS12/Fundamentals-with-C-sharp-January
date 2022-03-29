using System;
using System.Linq;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstElements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] secondElements = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToArray();
            for (int i = 0; i < secondElements.Length; i++)
            {
                foreach (string item in firstElements)
                {
                    if (item.Contains(secondElements[i]))
                    {
                        Console.Write($"{item} ");
                    }
                }

            }


        }

    }
}
