using System;

namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();
            PalindromeInteger(command);


        }

        static void PalindromeInteger(string command)
        {
            while (command != "END")
            {
                int palindromeInteger = 0;
                int reverseNumber = 0;
                int sum = 0;
                int temporaryVariable;
                
                palindromeInteger = int.Parse(command);
                temporaryVariable = palindromeInteger;
                while (palindromeInteger > 0)
                {
                    reverseNumber = palindromeInteger % 10;
                    sum = (sum * 10) + reverseNumber;
                    palindromeInteger = palindromeInteger / 10;
                }

                if (temporaryVariable == sum)
                {

                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                command = Console.ReadLine();

            }


            
        }
    }

}
