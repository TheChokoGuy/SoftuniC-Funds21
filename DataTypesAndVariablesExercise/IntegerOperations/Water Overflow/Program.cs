using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int tankLiters = 0;
            for (int i = 0; i < lines; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if(tankLiters + liters <= 255)
                {
                    tankLiters += liters;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(tankLiters);
        }
    }
}
