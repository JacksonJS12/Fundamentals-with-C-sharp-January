using System;
using System.Linq;

namespace _01.BurgerBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int citiesNumber = int.Parse(Console.ReadLine());
                
            decimal lostMoney = 0;
            decimal profitPerCity = 0;
            decimal totalProfit = 0;

            for (int i = 1; i <= citiesNumber ; i++)
            {
                string cityName = Console.ReadLine();
                decimal income = decimal.Parse(Console.ReadLine());
                decimal expenses = decimal.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    expenses = expenses + expenses * 0.5m;
                }

                if (i % 5 == 0)
                {
                    lostMoney = income * 0.1m;
                    profitPerCity = income - (lostMoney + expenses);
                    
                }
                else
                {
                    profitPerCity = income - expenses;
                }

                totalProfit += profitPerCity;
                Console.WriteLine($"In {cityName} Burger Bus earned {profitPerCity:f2} leva.");

            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}
