using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            int tempNum = 0;

            for (int i = 0; i < rotations; i++)
            {
                tempNum = arr[0];
                // 12 34 56 72 
                // 12 => 34
                // 34 56 72 72
                for (int x = 0; x < arr.Length - 1; x++)
                {
                    arr[x] = arr[x + 1];
                }
                // 34 56 72 12
                arr[arr.Length - 1] = tempNum;
                
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
