using System;
using System.Collections.Generic;

namespace P04.ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfProducts = int.Parse(Console.ReadLine());
            List<String> products = new List<String>();

            for (int i = 0; i < numOfProducts; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            for (int i = 0; i < products.Count; i++)
            { 
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
        }
    }
}
