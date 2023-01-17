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

            while(input != "end")
            {

                List<string> tokens = input.Split().ToList();

                switch(tokens[0])
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
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", list));

        }
    }
}
