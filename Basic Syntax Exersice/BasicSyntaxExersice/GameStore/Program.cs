using System;

namespace GameStore
{
    class Program
    {
        static void Main(string[] args)
            /*OutFall 4
            CS: OG
            Zplinter Zell
            Honored 2
            RoverWatch
            RoverWatch Origins Edition*/

        {
            double budget = double.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            while(input != "Game Time")
            {
                if(input == "OutFall 4" || input == "CS: OG" || input == "Zplinter Zell" || input == "Honored 2" || input == "RoverWatch" || input == "RoverWatch Origins Edition")
                {
                    Console.WriteLine($"Bought {input}");
                }
            }
        }
    }
}
