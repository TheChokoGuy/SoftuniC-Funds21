﻿using System;

namespace TownInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            double squareKm = double.Parse(Console.ReadLine());

            Console.WriteLine($"Town {name} has population of {population} and area {squareKm} square km.");
        }
    }
}
