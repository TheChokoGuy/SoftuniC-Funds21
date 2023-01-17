using System;
using System.Linq;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            while(array[1] != 0)
            {
            }

            Console.WriteLine(sum);
        }

    }
}
