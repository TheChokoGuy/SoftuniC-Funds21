using System;

namespace Repeat_String
{
    class Program
    {
        static void PrintInput(string input)
        {
            Console.Write(input);
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());
            for (int i = 0; i < repeat; i++)
            {
                PrintInput(input);
            }
        }
    }
}
