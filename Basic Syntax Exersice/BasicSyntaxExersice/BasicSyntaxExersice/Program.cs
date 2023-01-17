using System;

namespace BasicSyntaxExersice
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string stage = age <= 2 ? "baby" : age > 2 && age < 14 ? "child" : age >= 14 && age < 20 ? "teenager" : age >= 20 && age < 66 ? "adult" : "elder";

            /*if (age < 2 && age >= 0)
            {
                stage = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                stage = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                stage = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                stage = "adult";
            }
            else
            {
                stage = "elder";
            }*/

            Console.WriteLine(stage);
        }
    }
}
