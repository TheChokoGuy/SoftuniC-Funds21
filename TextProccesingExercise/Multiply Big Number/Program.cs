using System;
using System.Text;
namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); // 2344
            int mult = int.Parse(Console.ReadLine()); // 8
            StringBuilder sp = new StringBuilder();
            int reminder = 0;
            if (input == "0" || mult == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = input.Length - 1; i >= 0; i--) // 2344, input.Length - 1 = "4"
                {
                    int currDigit = int.Parse(input[i].ToString()); // 4
                    int product = currDigit * mult + reminder; // 4 * 8 + reminder
                    int result = product % 10; // 36 % 10 = 6
                    reminder = product / 10; // 36 / 10 = 3.6(int = 3)

                    sp.Insert(0, result.ToString()); // First time = 6 0 0 0, next = 9 6 0 0 , so on
                }

                if (reminder > 0)
                {
                    sp.Insert(0, reminder);
                }
                Console.WriteLine(sp);
            }
            

        }
    }
}