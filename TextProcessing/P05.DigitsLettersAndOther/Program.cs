using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string digits = new string(text.Where(Char.IsDigit).ToArray());

      

            string letters = new string(text.Where(Char.IsLetter).ToArray());

            Console.WriteLine(digits);
            Console.WriteLine(letters);
           
            for (int i = 0; i < text.Length; i++)
            {
                bool isDigitOrLetter = Char.IsLetterOrDigit(text[i]);
                if (!isDigitOrLetter)
                {
                    Console.Write(text[i]);
                }
            }
            
        }
    }
}
