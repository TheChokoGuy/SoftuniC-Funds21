using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int losts = int.Parse(Console.ReadLine());
            double headsetP = double.Parse(Console.ReadLine());
            double mouseP = double.Parse(Console.ReadLine());
            double keyboardP = double.Parse(Console.ReadLine());
            double displayP = double.Parse(Console.ReadLine());

            double expenses = 0;

            for (int currGame = 1; currGame <= losts; currGame++)
            {
                if(currGame % 2 == 0)
                {
                    expenses += headsetP;
                }
                if(currGame % 3 == 0)
                {
                    expenses += mouseP;
                }
                if(currGame % 6 == 0)
                {
                    expenses += keyboardP;
                }
                if(currGame % 12 == 0)
                {
                    expenses += displayP;
                }
            }
            
            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}
