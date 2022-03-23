using System;

namespace _7._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            double priceOfTicket = 0;
          
            if (age >= 0 && age <= 18)
            {
                if (typeOfDay == "Weekday")
                {
                    priceOfTicket = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    priceOfTicket = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    priceOfTicket = 5;
                }
                Console.WriteLine($"{priceOfTicket}$");
            }
            else if (age >= 18 && age <= 64)
            {
                if (typeOfDay == "Weekday")
                {
                    priceOfTicket = 18;
                }
                else if (typeOfDay == "Weekend")
                {
                    priceOfTicket = 20;
                }
                else if (typeOfDay == "Holiday")
                {
                    priceOfTicket = 12;
                }
                Console.WriteLine($"{priceOfTicket}$");
            }
            else if (age >= 64 && age <= 122)
            {
                if (typeOfDay == "Weekday")
                {
                    priceOfTicket = 12;
                }
                else if (typeOfDay == "Weekend")
                {
                    priceOfTicket = 15;
                }
                else if (typeOfDay == "Holiday")
                {
                    priceOfTicket = 10;
                }
                Console.WriteLine($"{priceOfTicket}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            
        }
    }
}
