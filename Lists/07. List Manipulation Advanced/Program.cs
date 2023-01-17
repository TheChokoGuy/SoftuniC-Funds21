using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {

                List<string> tokens = input.Split().ToList();

                switch (tokens[0])
                {
                    case "Add":
                        list.Add(int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        list.Remove(int.Parse(tokens[1]));
                        break;
                    case "RemoveAt":
                        list.RemoveAt(int.Parse(tokens[1]));
                        break;
                    case "Insert":
                        list.Insert(int.Parse(tokens[2]), int.Parse(tokens[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(Contains(list, int.Parse(tokens[1])));
                        break;
                    case "PrintEven":
                        PrintEven(list);
                        break;
                    case "PrintOdd":
                        PrintOdd(list);
                        break;
                    case "GetSum":
                        GetSum(list);
                        break;
                    case "Filter":
                        Filter(list, tokens[1], int.Parse(tokens[2]));
                        break;
                }
                input = Console.ReadLine();
            }

        }

        private static void Filter(List<int> list, string condition, int number)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                switch(condition)
                {
                    case "<":
                        if(list[i] < number)
                        {
                            newList.Add(list[i]);
                        }
                        break;
                    case ">":
                        if (list[i] > number)
                        {
                            newList.Add(list[i]);
                        }
                        break;
                    case "<=":
                        if (list[i] <= number)
                        {
                            newList.Add(list[i]);
                        }
                        break;
                    case ">=":
                        if (list[i] >= number)
                        {
                            newList.Add(list[i]);
                        }
                        break;
                }
                
            }
            if (list.Count != newList.Count)
            {
                Console.WriteLine(string.Join(" ", newList));
            }
        }

        static string Contains(List<int> list, int num)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] == num)
                {
                    return "Yes";
                }
            }
            return "No such number";
        }

        static void PrintEven(List<int> list)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] % 2 == 0)
                {
                    newList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }

        static void PrintOdd(List<int> list)
        {
            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    newList.Add(list[i]);
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }

        static void GetSum(List<int> list)
        {
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            Console.WriteLine(sum);
        }

    }
}
