﻿using System;

namespace Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            if(num >= 3.00)
            {
                Console.WriteLine("Passed!");
            }else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
