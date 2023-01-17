using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static int getEven(int num, int evenOrOdd)
        {
            int sum = 0;
            while(num > 0)
            {
                int digit = num % 10;
                if(digit % 0 == evenOrOdd)
                {
                    sum += digit;
                }
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = getEven(num, 0);
            int oddSum = getEven(num, 1);

            Console.WriteLine(evenSum * oddSum);
        }
    }
}
