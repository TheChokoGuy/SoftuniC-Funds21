using System;

namespace Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            double res1 = SumFactorial(num1);
            double res2 = SumFactorial(num2);
            Console.WriteLine($"{res1/res2:f2}");
        }

        static double SumFactorial(int num)
        {
            double result = 1;
            while(num > 1)
            {
                result *= num;
                num--;
            }

            return result;
        }
    }
}
