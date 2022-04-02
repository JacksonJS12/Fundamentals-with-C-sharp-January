using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> list = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToList();
            List<int> array = new List<int>();  
            foreach (var arr in list)
            {
                array.AddRange(arr.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList()
                         );
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
