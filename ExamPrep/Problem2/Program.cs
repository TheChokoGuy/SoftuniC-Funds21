using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"([=\/])([A-Z][A-z]{2,})\1");
            MatchCollection matches = regex.Matches(input);
            int points = 0;
            Console.Write("Destinations: ");
            int index = 0;
            foreach (Match match in matches)
            {
                index++;
                Console.Write($"{match.Groups[2].Value}");
                if (index < matches.Count)
                {
                    Console.Write(", ");
                }
                points += match.Groups[2].Value.Length;
            }

            Console.WriteLine();
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}