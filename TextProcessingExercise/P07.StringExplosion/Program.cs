using System;
using System.Text;

namespace P07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder outputText = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < inputString.Length; i++)
            {
                char currCh = inputString[i];

                if (currCh == '>')
                {
                    int currBombPower = GetIntValueOfCharacter(inputString[i + 1]);

                    outputText.Append(currCh);

                    bombPower += currBombPower;
                }
                else
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                    }
                    else
                    {
                        outputText.Append(currCh);
                    }
                }
            }
            Console.WriteLine(outputText.ToString());

        }

        static int GetIntValueOfCharacter(char ch)
        {
            return (int)ch - 48;
        }
    }
}
