using System;
using System.Collections.Generic;
using System.Linq;

namespace P003.HeartDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> neighborhoodAndHearts = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int lastIndex = 0;
            string command = Console.ReadLine();
            while (command != "Love!")
            {
                string[] jumps = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                int jumpLength = int.Parse(jumps[1]);

                //int startHouse = neighborhoodAndHearts[0];
                //int lastHouse = neighborhoodAndHearts[neighborhoodAndHearts.Length - 1];
               
                if(jumpLength > 0)
                {
                    
                    neighborhoodAndHearts[lastIndex + jumpLength] -= 2;
                    lastIndex += jumpLength;
                    if (jumpLength + lastIndex >= neighborhoodAndHearts.Count)
                    {
                       lastIndex = Math.Abs(neighborhoodAndHearts.Count - (jumpLength + lastIndex));
                    }
                    
                    if (neighborhoodAndHearts[lastIndex + jumpLength] == 0)
                    {
                        Console.WriteLine($"Place {neighborhoodAndHearts.IndexOf(0)} already had Valentine's day.");
                    }
                    if (neighborhoodAndHearts.Contains(0))
                    {
                        Console.WriteLine($"Place {neighborhoodAndHearts.IndexOf(0)} has Valentine's day.");
                    }
                   
                }


                command = Console.ReadLine();
            }
        }
    }
}
