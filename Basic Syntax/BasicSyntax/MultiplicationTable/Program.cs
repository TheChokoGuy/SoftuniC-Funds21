using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            while(n <= 10)
            {
                Console.WriteLine($"{num} X {n} = {num * n}");
                n++;
            }
        }
    }
}
