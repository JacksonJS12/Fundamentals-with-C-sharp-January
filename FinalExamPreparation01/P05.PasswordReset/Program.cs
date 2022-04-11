using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();
             
            while (command != "Done")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0];

                if (cmdType == "TakeOdd")
                {
                    char[] oddChars = password.Where((symbol, index) => index % 2 != 0)
                        .ToArray();

                    password = string.Join("", oddChars);
                    Console.WriteLine(password);
                }
                else if (cmdType == "Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int leght = int.Parse(cmdArgs[2]);

                    password = password.Remove(index, leght);
                    Console.WriteLine(password);
                }
                else if (cmdType == "Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];

                    if (password.Contains(substring))
                    {
                    password = password.Replace(substring, substitute);

                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
