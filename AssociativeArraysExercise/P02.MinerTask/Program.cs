using System;
using System.Collections.Generic;

namespace P02.MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> resourses = new Dictionary<string, long>();

            string resoursesCommand = Console.ReadLine();

            while (resoursesCommand != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resourses.ContainsKey(resoursesCommand))
                {
                    resourses[resoursesCommand] += quantity;
                }
                else
                {
                    resourses.Add(resoursesCommand, quantity);
                }

                resoursesCommand = Console.ReadLine();
            }

            foreach (var resoursesQuantityPair in resourses)
            {
                string currentResourse = resoursesQuantityPair.Key;
                long resourseQuantity = resoursesQuantityPair.Value;
                Console.WriteLine($"{currentResourse} -> {resourseQuantity}");
            }
        }
    }
}