using System;

namespace _3._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;

            if (groupType == "Students")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 8.45;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 9.80;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 10.46;
                }
                if (peopleCount >= 30)
                {

                    totalPrice = price * peopleCount - ((price * peopleCount) * 0.15);
                }
                else
                {
                    totalPrice = price * peopleCount;

                }
            }
            else if (groupType == "Business")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 10.90;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 15.60;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 16;
                }
                if (peopleCount >= 100)
                {
                    totalPrice = price * peopleCount - (price * 10);
                }
                else
                {
                    totalPrice = price * peopleCount;
                }
            }
            else if (groupType == "Regular")
            {
                if (dayOfTheWeek == "Friday")
                {
                    price = 15;
                }
                else if (dayOfTheWeek == "Saturday")
                {
                    price = 20;
                }
                else if (dayOfTheWeek == "Sunday")
                {
                    price = 22.50;
                }
                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    totalPrice = price * peopleCount - ((price * peopleCount) * 0.05);
                }
                else
                {
                    totalPrice = (price * peopleCount);

                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");

            }
        }
    }

