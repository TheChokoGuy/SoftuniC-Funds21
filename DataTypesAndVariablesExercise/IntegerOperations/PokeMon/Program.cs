using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double nStart = n;
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int pokes = 0;
            while(n > m && n - y > 0)
            {
                if(n == nStart * 0.5)
                {
                    if (n % y == 0)
                    {
                        n /= y;
                    }
                }
                n -= m;
                pokes++;
            }

            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}
