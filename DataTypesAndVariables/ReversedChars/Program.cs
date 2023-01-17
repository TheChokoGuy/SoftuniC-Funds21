using System;
using System.Linq;

namespace ReversedChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            string name = string.Empty;
            name += a + " ";
            name += b + " ";
            name += c + " ";

            //Reverse string with methods
            string reversed = new string(name.ToCharArray().Reverse().ToArray());

            Console.WriteLine(reversed);
        }
    }
}
