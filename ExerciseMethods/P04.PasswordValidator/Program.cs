using System;

namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int passwordMinLenght = 6;
            const int passwordMaxLenght = 10;
            const int passwordDigitsMinCount = 2;

            string password = Console.ReadLine();

            bool isPasswordValid = ValidatePassword(password, passwordMinLenght, passwordMaxLenght, passwordDigitsMinCount);

            if (isPasswordValid) 
            { 
                Console.WriteLine("Password is valid");
            }
        }

        static bool ValidatePassword(string password, int passwordMinLenght, int passwordMaxLenght, int passwordMinDigitsCount)
        {

            bool isPasswordValied = true;
            if (!ValidatePasswordLenght(password, passwordMinLenght, passwordMaxLenght))
            {
                Console.WriteLine($"Password must be between {passwordMinLenght} and {passwordMaxLenght} characters");
                isPasswordValied = false;
            }

            if (!ValidatePasswordIsAlphaNomerical(password))
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                isPasswordValied = false;
            }

            if (!ValidatePasswordDigitsMinCount(password, passwordMinDigitsCount))
            {
                Console.WriteLine($"Password must have at least {passwordMinDigitsCount} digits");
                isPasswordValied = false;
            }

            return isPasswordValied;

        }

        static bool ValidatePasswordLenght(string password, int minLenght, int maxLenght)
        {
            if (password.Length >= minLenght && password.Length <= maxLenght)
            {
                return true;
            }
            return false;
        }

        static bool ValidatePasswordIsAlphaNomerical(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }
                return true;

            
        }

        static bool ValidatePasswordDigitsMinCount(string password, int minDigitsCount)
        {
            int digitsCount = 0;
            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitsCount++;
                }
            }
                return digitsCount >= minDigitsCount;
            
        }
    }
}