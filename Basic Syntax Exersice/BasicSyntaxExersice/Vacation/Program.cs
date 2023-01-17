﻿using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerPerson = 0;
            double totalPrice = 0;
            if(group == "Students")
            {
                switch(day)
                {
                    case "Friday":
                        pricePerPerson = 8.45;
                        break;
                    case "Saturday":
                        pricePerPerson = 9.80;
                        break;
                    case "Sunday":
                        pricePerPerson = 10.46;
                        break;
                }

                totalPrice = people * pricePerPerson;
                if(people >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if(group == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        pricePerPerson = 10.90;
                        break;
                    case "Saturday":
                        pricePerPerson = 15.60;
                        break;
                    case "Sunday":
                        pricePerPerson = 16;
                        break;
                }

                totalPrice = people * pricePerPerson;

                if(people >= 100)
                {
                    totalPrice -= 10 * pricePerPerson;
                }
            }
            else if(group == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        pricePerPerson = 15;
                        break;
                    case "Saturday":
                        pricePerPerson = 20;
                        break;
                    case "Sunday":
                        pricePerPerson = 22.50;
                        break;
                }

                totalPrice = people * pricePerPerson;

                if(people >= 10 && people <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
