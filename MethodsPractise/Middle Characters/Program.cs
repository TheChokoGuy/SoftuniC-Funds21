using System;

namespace Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintMiddleChars(input);
        }

        static void PrintMiddleChars(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input.Length % 2 != 0)
                {
                    if (i == input.Length / 2)
                    {
                        Console.WriteLine(input[i]);
                    }
                }
                else if (input.Length % 2 == 0)
                {
                    if(i == input.Length / 2 - 1)
                    {
                        Console.Write(input[i]);
                        Console.Write(input[i + 1]);
                    }
                }
            }
        }
    }
}
