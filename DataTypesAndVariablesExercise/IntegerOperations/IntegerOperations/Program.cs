using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine((num1 + num2) / divider * multiplier);
            
        }
    }
}
