using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var britishPound = double.Parse(Console.ReadLine());
            decimal usd = (decimal)britishPound * 1.31M;
            Console.WriteLine($"{usd:f3}");
        }
    }
}
