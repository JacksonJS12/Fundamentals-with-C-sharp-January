using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> usernames = new List<string>();
            usernames = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = Console.ReadLine();
            string[] commandType = new string[command[2]];

            commandType = Console.ReadLine()
                    .Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            while (command != "Report")
            {

                if (commandType[0] == "Blacklist")
                {
                    Console.WriteLine($"{usernames} was blacklisted");
                    
                }
                if (commandType[0] == "Error")
                {
                    Console.WriteLine($"{usernames} was lost due to an error." );
                }
                if (commandType[0] == "Change")
                {
                    Console.WriteLine($"{usernames} changed his username to {usernames}");
                }

                command = Console.ReadLine();
               
            }

        }
    }
}
