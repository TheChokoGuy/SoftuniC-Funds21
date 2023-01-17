using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double highValue = double.MinValue;
            double snowballSnow = double.MinValue;
            double snowballTime = double.MinValue;
            double snowballQuality = double.MinValue;
            for (int i = 0; i < n; i++)
            {   double snowballSnow1 = double.Parse(Console.ReadLine());
                double snowballTime1 = double.Parse(Console.ReadLine());
                double snowballQuality1 = double.Parse(Console.ReadLine());
                double snowballValue = Math.Pow(snowballSnow1 / snowballTime1, snowballQuality1);
                if(snowballValue > highValue)
                {
                    highValue = snowballValue;
                    snowballSnow = snowballSnow1;
                    snowballTime = snowballTime1;
                    snowballQuality = snowballQuality1;

                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {highValue} ({snowballQuality})");
        }
    }
}
