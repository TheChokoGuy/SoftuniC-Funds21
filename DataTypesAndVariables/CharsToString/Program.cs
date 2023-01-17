using System;

namespace CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                char n = char.Parse(Console.ReadLine());
                name += n;
            }

            Console.WriteLine(name);
        }
    }
}
