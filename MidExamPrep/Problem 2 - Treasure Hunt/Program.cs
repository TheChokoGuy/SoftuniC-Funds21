using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2___Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> treasure = Console.ReadLine().Split("|").ToList();
            string input = Console.ReadLine();
            while(input != "Yohoho!")
            {
                List<string> tokens = input.Split().ToList();
                switch(tokens[0])
                {
                    case "Loot":
                        tokens.RemoveAt(0);
                        treasure = Loot(tokens, treasure);
                        break;
                    case "Drop":
                        treasure = Drop(int.Parse(tokens[1]), treasure);
                        break;
                    case "Steal":
                        treasure = Steal(int.Parse(tokens[1]), treasure);
                        break;
                }
                input = Console.ReadLine();
            }

            double sum = 0;

            for (int i = 0; i < treasure.Count; i++)
            {
                int itemCount = treasure[i].Length;
                sum += itemCount;
            }

            sum /= treasure.Count;
            if(treasure.Count != 0)
            {
                Console.WriteLine($"Average treasure gain: {sum:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine($"Failed treasure hunt.");
            }
        }

        static List<string> Loot(List<string> list, List<string> treasure)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(treasure.Contains(list[i]))
                {

                }
                else
                {
                    treasure.Insert(0, list[i]);
                }
            }

            return treasure;
        }

        static List<string> Drop(int index, List<string> treasure)
        {
            if(index <= treasure.Count - 1)
            {
                string item = treasure[index];
                treasure.RemoveAt(index);
                treasure.Add(item);
            }
            
            return treasure;
        }

        static List<string> Steal(int count, List<string> treasure)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{treasure[treasure.Count - 1 - i]}, ");
                treasure.RemoveAt(treasure.Count - 1);
            }
            Console.WriteLine();
            return treasure;
        }
    }
}
