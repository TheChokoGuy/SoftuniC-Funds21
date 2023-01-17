using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<string, int> types = new Dictionary<string, int>();
            while (input[0] != "End")
            {
                input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (!types.ContainsKey(input[0]))
                {
                    types.Add(input[0], 1);
                }
                else
                {
                    types[input[0]]++;
                }
            }
            
        }
    }
}