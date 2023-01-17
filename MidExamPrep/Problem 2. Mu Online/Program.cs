using System;
using System.Collections.Generic;
using System.Linq;
namespace Problem_2._Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split("|").ToList();
            int rooms = 0;
            int health = 100;
            int bitcoins = 0;
            for (int i = 0; i < input.Count; i++)
            {
                rooms++;
                List<string> tokens = input[i].Split().ToList();
               
                switch (tokens[0])
                {
                    case "potion":
                        if (health + int.Parse(tokens[1]) >= 100)
                        {
                            Console.WriteLine($"You healed for {100 - health} hp.");
                            Console.WriteLine($"Current health: {100} hp.");
                            health = 100;
                        }
                        else
                        {
                            Console.WriteLine($"You healed for {int.Parse(tokens[1])} hp.");
                            Console.WriteLine($"Current health: {health + int.Parse(tokens[1])} hp.");
                            health += int.Parse(tokens[1]);
                        }
                        break;
                    case "chest":
                        bitcoins += int.Parse(tokens[1]);
                        Console.WriteLine($"You found {tokens[1]} bitcoins.");
                        break;
                    default:
                        if(health - int.Parse(tokens[1]) > 0)
                        {
                            Console.WriteLine($"You slayed {tokens[0]}.");
                            health -= int.Parse(tokens[1]);
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {tokens[0]}.");
                            Console.WriteLine($"Best room: {rooms}");
                            health -= int.Parse(tokens[1]);
                        }
                        break;
                }
                if(health <= 0)
                {
                    break;
                }
            }

            if(health > 0)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
