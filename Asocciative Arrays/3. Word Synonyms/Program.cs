using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                
                if (!dict.ContainsKey(word))
                {
                    dict.Add(word, new List<string>());
                    dict[word].Add(synonim);
                }
                else
                {
                    dict[word].Add(synonim);
                }
            }

            foreach(var element in dict)
            {
                Console.Write($"{element.Key} - {string.Join(", ", element.Value)}");
                Console.WriteLine();
            }
        }
    }
}
