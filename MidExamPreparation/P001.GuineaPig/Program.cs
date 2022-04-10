using System;

namespace P001.GuineaPig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double quantityFood = double.Parse(Console.ReadLine());
            double quantityHay = double.Parse(Console.ReadLine());
            double quantityCover = double.Parse(Console.ReadLine());
            double pigWeight = double.Parse(Console.ReadLine());

            int day = 0;
            while (day != 30)
            {
                day++;
                quantityFood -= 0.3;
                if (day % 2 == 0)
                {
                    quantityHay -= quantityFood * 0.05;
                }
                if (day % 3 == 0)
                {
                    quantityCover -= pigWeight * 1 / 3;
                }


                if (quantityFood <= 0 || quantityHay <= 0 || quantityCover <= 0)
                {
                    Console.WriteLine($"Merry must go to the pet store!");
                    return;
                }

            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {quantityFood:f2}, Hay: {quantityHay:f2}, Cover: {quantityCover:f2}.");
        }
    }
}
