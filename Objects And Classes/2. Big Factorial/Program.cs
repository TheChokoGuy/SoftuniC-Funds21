using System;
using System.Numerics;
namespace _2._Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger num = Factorial.FactorialNum(n);
            Console.WriteLine(num);
        }
    }

    class Factorial
    {
        public static BigInteger FactorialNum(int n)
        {
            BigInteger num = 1;

            for (int i = 2; i < n + 1; i++)
            {
                num *= i;
            }

            return num;
        }
    }
}
