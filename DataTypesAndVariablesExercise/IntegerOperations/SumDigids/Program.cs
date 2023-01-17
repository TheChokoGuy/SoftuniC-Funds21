using System;

namespace SumDigids
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sum = 0;
            char[] digits = number.ToCharArray();

            for (int i = 0; i < digits.Length; i++)
            {
                sum += int.Parse(digits[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
