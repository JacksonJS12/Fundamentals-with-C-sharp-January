using System;

namespace P03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstObj = char.Parse(Console.ReadLine());
            char secondObj = char.Parse(Console.ReadLine());


            AsciiTable1(firstObj, secondObj);

            AsciiTable2(firstObj, secondObj);
        }

        static void AsciiTable1(char firstObj, char secondObj)
        {
            int charIndex1 = (int)firstObj;
            int charIndex2 = (int)secondObj;


            for (int i = charIndex1 + 1; i < charIndex2; i++)
            {
                Console.Write($"{(char)i} ");
            }




        }
        static void AsciiTable2(char firstObj, char secondObj)
        {
            int charIndex1 = (int)firstObj;
            int charIndex2 = (int)secondObj;

            for (int i = charIndex2 + 1; i < charIndex1; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}

