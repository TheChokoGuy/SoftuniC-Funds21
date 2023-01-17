using System;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sp = new StringBuilder();
            
            foreach (var letter in input)
            {
                int intValue = letter;
                int replacment = intValue + 3;
                char newLetter = (char) replacment;
                sp.Append(newLetter);
            }

            Console.WriteLine(sp);
        }
    }
}