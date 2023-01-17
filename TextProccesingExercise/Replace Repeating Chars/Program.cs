using System;

namespace Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char prevChar = input[0];
            Console.Write(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (prevChar != input[i])
                {
                    prevChar = input[i];
                    
                    Console.Write(prevChar);

                }
                
            }
        }
    }
}