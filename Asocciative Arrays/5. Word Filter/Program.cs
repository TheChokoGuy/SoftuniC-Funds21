using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split()
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
