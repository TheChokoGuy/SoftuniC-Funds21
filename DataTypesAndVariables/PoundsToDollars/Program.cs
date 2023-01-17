using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            decimal num2 = number * 1.31M;
            Console.WriteLine($"{num2:f3}");
        }
    }
}
