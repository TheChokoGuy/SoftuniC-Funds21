﻿using System;

namespace Calculations
{
    class Program
    {

        static void Main(string[] args)
        {
            string calculation = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            switch(calculation)
            {
                case "add":
                    Add(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;
                case "subtract":
                    Substract(a, b);
                    break;
                case "divide":
                    Divide(a, b);
                    break;
            }
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

    }
}
