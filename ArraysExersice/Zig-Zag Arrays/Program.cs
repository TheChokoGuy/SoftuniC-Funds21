using System;
using System.Linq;
namespace Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] evenArr = new int[lines];
            int[] oddArr = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] numbersOnCurrLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if(i % 2 == 0)
                {
                    oddArr[i] = numbersOnCurrLine[0];
                    evenArr[i] = numbersOnCurrLine[1];
                }
                else
                {
                    evenArr[i] = numbersOnCurrLine[0];
                    oddArr[i] = numbersOnCurrLine[1];
                }
            }

            Console.WriteLine(String.Join(" ", oddArr));
            Console.WriteLine(String.Join(" ", evenArr));
        }
    }
}
