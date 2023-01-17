using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(string element in input)
            {
                string word = element.ToLower();
                if(dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            foreach(var element in dict)
            {
                if(element.Value % 2 != 0)
                {
                    Console.Write($"{element.Key} ");
                }
                
            }
        }
    }
}
