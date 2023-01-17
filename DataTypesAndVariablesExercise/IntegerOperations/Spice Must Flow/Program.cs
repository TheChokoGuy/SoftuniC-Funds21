using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSpice = int.Parse(Console.ReadLine());
            int spiceAteByWorkers = 26;
            int collectedSpice = 0;
            int days = 0;
            while(startSpice >= 100)
            {
                collectedSpice += startSpice - spiceAteByWorkers;
                startSpice -= 10;
                days++;
                if(startSpice < 100)
                {
                    collectedSpice -= spiceAteByWorkers;
                }
            }

            Console.WriteLine(days);
            Console.WriteLine(collectedSpice);
        }
    }
}
