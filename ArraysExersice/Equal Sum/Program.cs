using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isThereNum = false;

            if(array.Length != 1)
            {
                for (int numInArr = 0; numInArr < array.Length; numInArr++)
                {
                    for (int i = 0; i < numInArr; i++)
                    {
                        leftSum += array[i];
                    }
                    for (int x = 0; x > numInArr; x--)
                    {
                        rightSum += array[x];
                    }
                    if (leftSum == rightSum)
                    {
                        Console.WriteLine(numInArr);
                        isThereNum = true;
                        break;
                    }

                    leftSum = 0;
                    rightSum = 0;
                }

                if(isThereNum == false)
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine(0);
            }
            
        }
    }
}
