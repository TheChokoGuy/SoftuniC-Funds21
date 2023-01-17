using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            float number = float.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Pow(number, power));
        }
    }
}
