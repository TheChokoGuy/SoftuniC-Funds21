using System;

namespace Grades
{
    class Program
    {
        static void grade()
        {
            double grade = double.Parse(Console.ReadLine());

            switch (grade)
            {
                case double num when num >= 2 && num < 3:
                    Console.WriteLine("Fail");
                    break;
                case double num when num >= 3 && num < 3.50:
                    Console.WriteLine("Poor");
                    break;
                case double num when num >= 3.50 && num < 4.50:
                    Console.WriteLine("Good");
                    break;
                case double num when num >= 4.50 && num < 5.50:
                    Console.WriteLine("Very good");
                    break;
                case double num when num >= 5.50 && num <= 6:
                    Console.WriteLine("Excellent");
                    break;
            }
            
        }
        static void Main(string[] args)
        {
            grade();
        }
    }
}
