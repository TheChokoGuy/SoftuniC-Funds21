using System;

namespace LowerOrUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string lowN = n.ToLower();
            string upN = n.ToUpper();
            if(n == lowN)
            {
                Console.WriteLine("lower-case");
            }
            if(n == upN)
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
