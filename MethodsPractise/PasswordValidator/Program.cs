using System;
using System.Linq;
namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isEnoughCharacters = input.Length >= 6 && input.Length <= 10;
            bool isOnlyLettersAndDigits = DoesContainLettersAndDigits(input);
            bool isMoreThan2Digits = DoesContainMoreThat2Digits(input);

            if(isEnoughCharacters && isOnlyLettersAndDigits && isMoreThan2Digits)
            {
                Console.WriteLine("Password is valid");
            }
            if(!isEnoughCharacters)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if(!isOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if(!isMoreThan2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }

        static bool DoesContainLettersAndDigits(string input)
        {
            foreach (char character in input)
            {
                if(!char.IsLetterOrDigit(character))
                {
                    return false;
                }
            }
            return true;
        }

        static bool DoesContainMoreThat2Digits(string input)
        {
            int digitCount = 0;
            foreach (char character in input)
            {
                if(char.IsDigit(character))
                {
                    digitCount++;
                }
            }

            return digitCount >= 2 ? true : false;
        }
    }
}
