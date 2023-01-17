using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            switch(order)
            {
                case "coffee":
                    Coffe(number);
                    break;
                case "water":
                    Water(number);
                    break;
                case "coke":
                    Coke(number);
                    break;
                case "snacks":
                    Snacks(number);
                    break;
            }
        }

        static void Coffe(int number)
        {
            Console.WriteLine($"{1.50 * number:f2}");
        }
        static void Water(int number)
        {
            Console.WriteLine($"{1.00 * number:f2}");
        }
        static void Coke(int number)
        {
            Console.WriteLine($"{1.40 * number:f2}");
        }
        static void Snacks(int number)
        {
            Console.WriteLine($"{2.00 * number:f2}");
        }
    }
}
