using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneySum = 0;
            string input = Console.ReadLine();
            while(input != "Start")
            {
                double tempMoney = double.Parse(input);
                if(tempMoney == 0.1 || tempMoney == 0.2 || tempMoney == 0.5 || tempMoney == 1|| tempMoney == 2)
                {
                    moneySum += tempMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {tempMoney}");
                }
                input = Console.ReadLine();
            }
            while(input != "End")
            {
                input = Console.ReadLine();
                switch(input)
                {
                    case "Nuts":
                        if(moneySum - 2 >= 0)
                        {
                            Console.WriteLine("Purchased nuts");
                            moneySum -= 2;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (moneySum - 0.7 >= 0)
                        {
                            Console.WriteLine("Purchased water");
                            moneySum -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (moneySum - 1.5 >= 0)
                        {
                            Console.WriteLine("Purchased crisps");
                            moneySum -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (moneySum - 0.8 >= 0)
                        {
                            Console.WriteLine("Purchased soda");
                            moneySum -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (moneySum - 1 >= 0)
                        {
                            Console.WriteLine("Purchased coke");
                            moneySum -= 1;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "End":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }
            Console.WriteLine($"Change: {moneySum:f2}");
        }
    }
}
