using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int startNum = number;
            int factSum = 0;

            while(number > 0)
            {
                //we get the last digit of the number
                int currentNum = number % 10;
                //we remove the last digit of the number
                number /= 10;
                //we loop for the factorial
                int currFactNum = 1;
                for (int i = 1; i <= currentNum ; i++)
                {
                    currFactNum *= i;
                }
                //we add the fact of the curr num to the sum
                factSum += currFactNum;
            }

            string answer = factSum == startNum ? "yes" : "no";
            Console.WriteLine(answer);
        }
    }
}
