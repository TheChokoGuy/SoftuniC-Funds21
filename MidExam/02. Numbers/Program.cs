using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while(input != "Finish")
            {
                List<string> tokens = input.Split().ToList();
                switch(tokens[0])
                {
                    case "Add":
                        list = Add(list, int.Parse(tokens[1]));
                        break;
                    case "Remove":
                        list = Remove(list, int.Parse(tokens[1]));
                        break;
                    case "Replace":
                        list = Replace(list, int.Parse(tokens[1]), int.Parse(tokens[2]));
                        break;
                    case "Collapse":
                        list = Collapse(list, int.Parse(tokens[1]));
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));

            static List<int> Add(List<int> list, int value)
            {
                List<int> newList = list;
                newList.Add(value);
                return newList; 
            }

            static List<int> Remove(List<int> list, int value)
            {
                List<int> newList = list;
                newList.Remove(value);
                return newList;
            }

            static List<int> Replace(List<int> list, int value, int replacement)
            {
                List<int> newList = list;
                for (int i = 0; i < newList.Count; i++)
                {
                    if(newList[i] == value)
                    {
                        newList[i] = replacement;
                        break;
                    }
                }
                return newList;
            }

            static List<int> Collapse(List<int> list, int value)
            {
                List<int> newList = list;
                for (int i = 0; i < newList.Count; i++)
                {
                    if (newList[i] < value)
                    {
                        newList.RemoveAt(i);
                        i--;
                    }
                }
                return newList;
            }
        }
    }
}
