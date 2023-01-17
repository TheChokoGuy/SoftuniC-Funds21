using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;

namespace Problem_3_The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string name = input[0];
                string[] compAndKey = new string[] {input[1], input[2]};
                pieces.Add(name, compAndKey);
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] splitedCommand = command.Split("|");
                switch (splitedCommand[0])
                {
                    case "Add":
                        pieces = Add(splitedCommand[1], splitedCommand[2], splitedCommand[3], pieces);
                        break;
                    case "Remove":
                        pieces = Remove(splitedCommand[1], pieces);
                        break;
                    case "ChangeKey":
                        pieces = ChangeKey(splitedCommand[1], splitedCommand[2], pieces);
                        break;
                }
                command = Console.ReadLine();
            }

            pieces = Sort(pieces);
            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}"); 
            }

        }

        static Dictionary<string, string[]> Add(string piece, string comp, string key, Dictionary<string, string[]> dict)
        {
            Dictionary<string, string[]> newDict = dict;
            if (!newDict.ContainsKey(piece))
            {
                newDict.Add(piece, new string[]{comp, key});
                Console.WriteLine($"{piece} by {comp} in {key} added to the collection!");
            }
            else
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            return newDict;
        }

        static Dictionary<string, string[]> Remove(string piece, Dictionary<string, string[]> dict)
        {
            Dictionary<string, string[]> newDict = dict;
            if (!newDict.ContainsKey(piece))
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
            else
            {
                newDict.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            return newDict;
        }

        static Dictionary<string, string[]> ChangeKey(string piece, string newKey, Dictionary<string, string[]> dict)
        {
            Dictionary<string, string[]> newDict = dict;
            if (newDict.ContainsKey(piece))
            {
                newDict[piece][1] = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
            return newDict;
        }
        
        static Dictionary<string, string[]> Sort(Dictionary<string, string[]> whichDictionary)
        {
            return whichDictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
        }
    }
}