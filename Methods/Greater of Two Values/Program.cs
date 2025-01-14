﻿using System;

namespace Greater_of_Two_Values
{
    class Program
    {
        static int getMax(int a, int b)
        {
            if(a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char getMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string getMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            if(type == "string")
            {
                Console.WriteLine(getMax(a, b));
            }
            else if(type == "int")
            {
                Console.WriteLine(getMax(int.Parse(a), int.Parse(b)));
            }
            else if(type == "char")
            {
                Console.WriteLine(getMax(char.Parse(a), char.Parse(b)));
            }
        }
    }
}
