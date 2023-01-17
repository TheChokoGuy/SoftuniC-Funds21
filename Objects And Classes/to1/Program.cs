using System;
using System.Collections.Generic;
using System.Linq;

namespace to1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int swapPos = rnd.Next(input.Length);
                string temp = input[i];
                input[i] = input[swapPos];
                input[swapPos] = temp;
            }

            Console.WriteLine(string.Join("\n", input));
        }
    }
}
