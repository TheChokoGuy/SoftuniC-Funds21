using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
namespace Problem_2_Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([#\@])([A-z]{3,})\1\1([A-z]{3,})\1");
            MatchCollection matches = regex.Matches(input);
            int validPairs = matches.Count;
            Dictionary<string, string> mirrors = new Dictionary<string, string>();
            foreach (Match match in matches)
            {
                string word1 = match.Groups[2].ToString();
                char[] word1Rev = word1.ToCharArray();
                Array.Reverse(word1Rev);
                string word2 = match.Groups[3].ToString();
                char[] word2Rev = word2.ToCharArray();
                Array.Reverse(word2Rev);
                string word1RevString = new string(word1Rev);
                string word2RevString = new string(word2Rev);
                if (word1RevString == word2 || word2RevString == word1)
                {
                    mirrors.Add(word1, word2);
                }
            }

            if (validPairs != 0)
            {
                Console.WriteLine($"{validPairs} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (mirrors.Count != 0)
            {
                Console.WriteLine("The mirror words are:");
                int index = 0;
                foreach (var pair in mirrors)
                {
                    index++;
                    Console.Write($"{pair.Key} <=> {pair.Value}");
                    if (index < mirrors.Count)
                    {
                        Console.Write(", ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}