using System;

namespace Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double volumeOfBigKeg = int.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if(volume > volumeOfBigKeg)
                {
                    volumeOfBigKeg = volume;
                    biggestKeg = name;
                }
            }

            Console.WriteLine(biggestKeg);
        }
    }
}
