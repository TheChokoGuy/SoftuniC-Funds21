using System;
using System.Text.RegularExpressions;

namespace Problem_2_Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"(\|?#?)([A-z ]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]+)(\1)");
            int calories = 0;
            foreach (Match match in matches)
            {
                string foodName = match.Groups[2].ToString();
                string date = match.Groups[3].ToString();
                int cal = int.Parse(match.Groups[4].ToString());
                calories += cal;
            }

            int daysToLast = calories / 2000;
            Console.WriteLine($"You have food to last you for: {daysToLast} days!");
            
            foreach (Match match in matches)
            {
                string foodName = match.Groups[2].ToString();
                string date = match.Groups[3].ToString();
                int cal = int.Parse(match.Groups[4].ToString());
                calories += cal;
                Console.WriteLine($"Item: {foodName}, Best before: {date}, Nutrition: {cal}");
            }
        }
    }
}