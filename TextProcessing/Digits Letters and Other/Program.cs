using System;
using System.Collections.Generic;

namespace Digits_Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> symbols = new List<char>();
            
            foreach (char letter in input)
            {
                if (char.IsDigit(letter) == true)
                {
                    digits.Add(letter);
                }
                else if (char.IsLetter(letter) == true)
                {
                    letters.Add(letter);
                }
                else
                {
                    symbols.Add(letter);
                }
            }

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", symbols));

            
        }
    }
}