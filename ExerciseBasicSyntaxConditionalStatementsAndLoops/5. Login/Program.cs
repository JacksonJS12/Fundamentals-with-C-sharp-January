using System;
using System.Text;

namespace _5._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

           string password = string.Empty;

            for (int reversIndex = username.Length - 1; reversIndex >= 0; reversIndex--)
            {
                password += username[reversIndex]; 
            }
            

            for (int count = 1; count <= 4; count++)
            {
                string enteredPassword = Console.ReadLine();

                if (enteredPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                        continue;
                    }
                }
            }
        }

    }
}
