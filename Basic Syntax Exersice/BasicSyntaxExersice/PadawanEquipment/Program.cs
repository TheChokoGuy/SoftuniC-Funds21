
using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get Input
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lighsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            //Extra Sabers
            double numberOfSabers = Math.Ceiling(students * 1.1);
            //Every 6xth student gets free belt
            double numOfFreeBelts = Math.Floor(students / 6.0);

            //total prices
            double totalPriceSaber = numberOfSabers * lighsaberPrice;
            double finalPriceForRobes = robePrice * students;
            double finalPriceForBelts = (students - numOfFreeBelts) * beltPrice;

            double totalPrice = finalPriceForBelts + finalPriceForRobes + totalPriceSaber;

            //if money is enough
            if(budget >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(totalPrice - budget):f2}lv more.");
            }
        }
    }
}
