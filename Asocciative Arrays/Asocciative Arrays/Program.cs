using System;
using System.Collections.Generic;
using System.Linq;

namespace Asocciative_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get input
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //Sort input in dictionary
            SortedDictionary<int, int> SortedInput = new SortedDictionary<int, int>();
            //Loop through every num in the input and add it to dictionary
            foreach(int num in input)
            {
                if(SortedInput.ContainsKey(num))
                {
                    SortedInput[num]++;
                }
                else
                {
                    SortedInput.Add(num, 1);
                }
            }
            //Loop through the sorted dictionary and console elements
            foreach(var number in SortedInput)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
