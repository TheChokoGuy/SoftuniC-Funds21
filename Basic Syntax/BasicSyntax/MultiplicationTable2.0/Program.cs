using System;

namespace MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine($"{num} X {n} = {num * n}");
                n++;
            } while (n <= 10);
        }
    }
}
