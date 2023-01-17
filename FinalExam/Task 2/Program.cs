using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"([!])([A-Z][a-z]{2,})\1(:)\[([A-z]{8,})]");
            List<Match> matches = new List<Match>();
            List<int> acssiVal = new List<int>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    matches.Add(regex.Match(input));
                    if (matches.Count != 0)
                    {
                        Match currentMatch = matches[i];
                        foreach (char letter in currentMatch.Groups[4].ToString())
                        {
                            if (char.IsLetter(letter))
                            {
                                acssiVal.Add((int) letter);
                            }
                        }
                        Console.WriteLine($"{matches[i].Groups[2].ToString()}: {string.Join(" ", acssiVal)}");
                        acssiVal.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }

            
        }
    }
}