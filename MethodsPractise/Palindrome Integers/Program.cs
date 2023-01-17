using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input != "END")
            {
                int num = int.Parse(input);
                isPalindromeNum(num, input);
                input = Console.ReadLine();
            }
        }

        static void isPalindromeNum(int num, string input)
        {
            int startNum = num;
            int[] arr = new int[input.Length];
            while(num > 0)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int lastNum = num % 10;
                    arr[i] = lastNum;
                    num /= 10;
                }
            }

            if(arr.ToString() == input)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
