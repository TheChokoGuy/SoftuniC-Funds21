using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] topNums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                bool isTop = true;
                for (int x = i + 1; x < arr.Length; x++)
                {
                    if(arr[i] <= arr[x])
                    {
                        isTop = false;
                    }
                }

                if (isTop)
                {
                    Console.Write(arr[i] + " ");
                }
            }

        }
    }
}
