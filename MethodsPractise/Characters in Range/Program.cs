using System;

namespace Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char c1 = char.Parse(Console.ReadLine());
            char c2 = char.Parse(Console.ReadLine());

            ASCIItableNums(c1, c2);
        }

        static void ASCIItableNums(char c1, char c2)
        {
            int startChar = Math.Min(c1, c2);
            int endChar = Math.Max(c1, c2);

            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
