using System;

namespace Methods
{
    class Program
    {
        static void posOrNeg(int num)  
        {

            if(num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }
            else if(num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            posOrNeg(num);
        }
    }
}
