using System;
using System.Collections.Generic;
using System.Linq;
namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] < 0)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            if(list.Count > 0)
            {
                for (int i = list.Count - 1; i > -1; i--)
                {
                    Console.Write(list[i] + " ");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
