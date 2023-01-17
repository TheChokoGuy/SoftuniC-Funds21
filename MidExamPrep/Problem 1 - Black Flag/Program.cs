using System;

namespace Problem_1___Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());

            double totalPlumber = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlumber += dailyPlunder;

                if (i % 3 == 0)
                {
                    totalPlumber += dailyPlunder * 0.50;
                }
                if(i % 5 == 0)
                {
                    totalPlumber -= totalPlumber * 0.30;
                }
            }

            if(totalPlumber >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlumber:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {totalPlumber/expectedPlunder*100:f2}% of the plunder.");
            }

        }
    }
}
