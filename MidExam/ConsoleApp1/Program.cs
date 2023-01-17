using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int buiscitsPerWorkerPerDay = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int buiscetsOfFactory2 = int.Parse(Console.ReadLine());

            double buiscets = 0;

            for (int i = 0; i < 30; i++)
            {
                if (i % 3 == 0)
                {
                    buiscets += Math.Floor(buiscitsPerWorkerPerDay * workers * 0.75);
                }
                else
                {
                    buiscets += buiscitsPerWorkerPerDay * workers;
                }
            }

            Console.WriteLine($"You have produced {buiscets} biscuits for the past month.");

            if(buiscets > buiscetsOfFactory2)
            {
                Console.WriteLine($"You produce {buiscets/buiscetsOfFactory2 * 100 - 100:f2} percent more biscuits.");
            }
            else if (buiscets < buiscetsOfFactory2)
            {
                Console.WriteLine($"You produce {100 - buiscets / buiscetsOfFactory2 * 100:f2} percent less biscuits.");
            }
        }
    }
}