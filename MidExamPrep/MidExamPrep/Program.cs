using System;
using System.Collections.Generic;
using System.Linq;

namespace MidExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            int x = 0;
            string input = Console.ReadLine();

            while(input != "Love!")
            {
                string[] inputTokens = input.Split();
                int jump = int.Parse(inputTokens[1]);
                if(x + jump >= list.Count)
                {
                    x = 0;
                }
                else
                {
                    x += jump;
                }

                list[x] -= 2;
                if(list[x] == 0)
                {
                    Console.WriteLine($"Place {x} has Valentine's day.");
                }

                if(list[x] < 0)
                {
                    Console.WriteLine($"Place {x} already had Valentine's day.");
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {x}.");
            if(!list.Any(number => number > 0))
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {list.Count(number => number > 0)} places.");
            }
            

        }

    }
}
