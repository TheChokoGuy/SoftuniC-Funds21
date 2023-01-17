using System;

namespace RefactorVolumeOfPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght, width, height,  V = 0;
            lenght = double.Parse(Console.ReadLine());
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            V = (lenght * width * height) / 3;
            Console.Write("Length: ");

            Console.Write("Width: ");

            Console.Write("Height: ");

            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
