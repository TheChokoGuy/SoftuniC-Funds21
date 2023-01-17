using System;
using System.Linq;
using System.Threading;

namespace Problem_1_Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] tokens = command.Split(":|:");
                if (tokens[0] == "ChangeAll")
                {
                    input = input.Replace(tokens[1], tokens[2]);
                    Console.WriteLine(input);
                }
                else if (tokens[0] == "InsertSpace")
                {
                    input = input.Insert(int.Parse(tokens[1]), " ");
                    Console.WriteLine(input);
                }
                else if (tokens[0] == "Reverse")
                {
                    string substring = tokens[1];
                    if (input.Contains(substring))
                    {
                        int indexOfSub = input.IndexOf(substring);
                        input = input.Remove(indexOfSub, substring.Length);
                        input += string.Join("", substring.Reverse());
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}