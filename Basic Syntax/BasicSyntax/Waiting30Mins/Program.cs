using System;

namespace Waiting30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            if(mins + 30 >= 60)
            {
                hours++;
                if(hours >= 24)
                {
                    hours = 0;
                }
                mins = (mins + 30) - 60;
            }
            else
            {
                mins += 30;
            }
            Console.WriteLine($"{hours}:{mins:d2}");
        }
    }
}
