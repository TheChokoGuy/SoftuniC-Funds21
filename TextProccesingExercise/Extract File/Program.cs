using System;

namespace Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(@"\");
            string lastPath = input[input.Length - 1];
            string[] splittedPath = lastPath.Split(".");

            string name = splittedPath[0];
            string extention = splittedPath[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}