using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Animal> animals = new SortedDictionary<string, Animal>();
            string command = Console.ReadLine();
            SortedDictionary<string, int> areas = new SortedDictionary<string, int>();
            while (command != "EndDay")
            {
                string[] splittedCommand = command.Split(": ");
                string[] splittedStuff = splittedCommand[1].Split("-");
                if (splittedCommand[0] == "Add")
                {
                    if (animals.ContainsKey(splittedStuff[0]))
                    {
                        animals[splittedStuff[0]].food += int.Parse(splittedStuff[1]);
                    }
                    else
                    {
                        animals.Add(splittedStuff[0], new Animal(splittedStuff[2], int.Parse(splittedStuff[1])));
                        if (!areas.ContainsKey(splittedStuff[2]))
                        {
                            areas.Add(splittedStuff[2], 1);
                        }
                        else
                        {
                            areas[splittedStuff[2]]++;
                        }
                    }
                }
                else
                {
                    if (animals.ContainsKey(splittedStuff[0]))
                    {
                        animals[splittedStuff[0]].food -= int.Parse(splittedStuff[1]);
                        if (animals[splittedStuff[0]].food <= 0)
                        {
                            Console.WriteLine($"{splittedStuff[0]} was successfully fed");
                            if (areas.ContainsKey(animals[splittedStuff[0]].area))
                            {
                                if (areas[animals[splittedStuff[0]].area] == 1)
                                {
                                    areas.Remove(animals[splittedStuff[0]].area);
                                }
                                else
                                {
                                    areas[animals[splittedStuff[0]].area]--;
                                }
                            }
                            animals.Remove(splittedStuff[0]);
                            
                        }
                    }
                }
                command = Console.ReadLine();
            }
            
            var sortedAnimas = from entry in animals orderby entry.Value.food descending select entry;
            Console.WriteLine("Animals:");
            foreach (var animal in sortedAnimas)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value.food}g");
            }

            var sortedAreas = from entry in areas orderby entry.Key ascending select entry;
            Console.WriteLine("Areas with hungry animals:");
            foreach (var area in sortedAreas)
            {
                Console.WriteLine($" {area.Key}: {area.Value}");
            }
        }
    }

    class Animal
    {
        public int food { get; set; }
        public string area { get; set; }
        
        public Animal(string _area, int _food)
        {
            area = _area;
            food = _food;
        }
    }
}