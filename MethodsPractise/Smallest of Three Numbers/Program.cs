using System;

namespace Smallest_of_Three_Numbers
{
    class Program
    {
        static int SmallestOf3Nums(int n1, int n2, int n3)
        {
            if(n1 < n2)
            {
                if(n1 < n3)
                {
                    return n1;
                }
                else
                {
                    return n3;
                }
            }
            if(n2 < n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
            return n1;
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(SmallestOf3Nums(a,b,c));
        }
    }
}
