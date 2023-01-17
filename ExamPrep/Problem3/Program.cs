using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> cars = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                int[] milAndfuel = new int[2];
                milAndfuel[0] = int.Parse(input[1]);
                milAndfuel[1] = int.Parse(input[2]);
                cars.Add(input[0], milAndfuel);
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] splittedCommand = command.Split(" : ");
                if (splittedCommand[0] == "Drive")
                {
                    Drive(splittedCommand[1], cars[splittedCommand[1]], int.Parse(splittedCommand[2]), int.Parse(splittedCommand[3]), cars);
                }
                else if (splittedCommand[0] == "Refuel")
                {
                    Refuel(splittedCommand[1], cars[splittedCommand[1]], int.Parse(splittedCommand[2]));
                }
                else if (splittedCommand[0] == "Revert")
                {
                    Revert(splittedCommand[1], cars[splittedCommand[1]], int.Parse(splittedCommand[2]));
                }

                command = Console.ReadLine();
            }
            
            var carsSortedByMilage = from entry in cars orderby entry.Value[0] descending select entry;
            foreach (var car in carsSortedByMilage)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }

        static void Drive(string name, int[] milAndFuel, int distance, int fuelNeeded, Dictionary<string, int[]> cars)
        {
            if (milAndFuel[1] - fuelNeeded >= 0)
            {
                milAndFuel[1] -= fuelNeeded;
                milAndFuel[0] += distance;
                Console.WriteLine($"{name} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                if (milAndFuel[0] >= 100000)
                {
                    Console.WriteLine($"Time to sell the {name}!");
                    cars.Remove(name);
                }
                
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }

        static void Refuel(string name, int[] milAndFuel, int refuel)
        {
            if (milAndFuel[1] + refuel > 75)
            {
                int beforeRef = milAndFuel[1];
                milAndFuel[1] += 75 - milAndFuel[1];
                Console.WriteLine($"{name} refueled with {75 - beforeRef} liters");
            }
            else
            {
                milAndFuel[1] += refuel;
                Console.WriteLine($"{name} refueled with {refuel} liters");
            }
        }

        static void Revert(string name, int[] milAndFuel, int km)
        {
            milAndFuel[0] -= km;
            if (milAndFuel[0] < 10000)
            {
                milAndFuel[0] = 10000;
            }
            else
            {
                Console.WriteLine($"{name} mileage decreased by {km} kilometers");
            }
        }
        
    }
}