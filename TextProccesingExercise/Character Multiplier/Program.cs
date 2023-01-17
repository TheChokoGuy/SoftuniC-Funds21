using System;
using System.Collections.Concurrent;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string input1 = input[0];
            string input2 = input[1];
            
            int minLength = Math.Min(input1.Length, input2.Length);
            int maxLength = Math.Max(input1.Length, input2.Length);
            CharMul(minLength, maxLength, input1, input2);
        }

        private static void CharMul(int minLength,int maxLength, string input1, string input2)
        {
            int sum = 0;
            bool isSameLength = input1.Length == input2.Length;
            bool isIn1Bigger = input1.Length > input2.Length;
            for (int i = 0; i < minLength; i++)
            {
                int multiplication = input1[i] * input2[i];
                sum += multiplication;
            }

            if (isSameLength)
            {
                Console.WriteLine(sum);
            }
            else
            {
                for (int i = 0; i < maxLength - minLength; i++)
                {
                    if (isIn1Bigger)
                    {
                        sum += input1[i + minLength];
                    }
                    else
                    {
                        sum += input2[i + minLength];
                    }
                }
                Console.WriteLine(sum);
            }
        }
    }
}