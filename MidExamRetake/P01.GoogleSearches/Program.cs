using System;

namespace MidExamRetake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal moneyPerSearch = decimal.Parse(Console.ReadLine());
            int numberOfUsers = int.Parse(Console.ReadLine());

            decimal totalMoney = 0;
            for (int i = 1; i <= numberOfUsers; i++)
            {
                int numberOfSearchesEachUser = int.Parse(Console.ReadLine());

                decimal earnedMoneyPerSearch = numberOfSearchesEachUser * moneyPerSearch;

                if (numberOfSearchesEachUser > 5)
                {
                    earnedMoneyPerSearch *= 2;
                }
                else if (numberOfSearchesEachUser <= 1)
                {
                    earnedMoneyPerSearch = 0;
                }
                if (i % 3 == 0)
                {
                    earnedMoneyPerSearch *= 3;

                    if (numberOfSearchesEachUser > 5)
                    {
                       moneyPerSearch *= 2;

                    }
                    else if (numberOfSearchesEachUser <= 1)
                    {
                        continue;
                    }


                    
                }
                totalMoney += earnedMoneyPerSearch;
            }
            Console.WriteLine($"Total money earned: {totalMoney:f2}");
        }
    }
}
