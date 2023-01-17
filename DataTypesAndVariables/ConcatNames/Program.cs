using System;

namespace ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            string name2 = Console.ReadLine();
            string inBetween = Console.ReadLine();

            Console.WriteLine(name1 + inBetween + name2);
        }
    }
}
