using System;

namespace Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            string _operator = Console.ReadLine();
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(n1, _operator, n2));
        }

        private static double Calculate(int n1, string op, int n2)
        {
            int result = 0;
            switch(op)
            {
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    result = n1 / n2;
                    break;
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
            }

            return result;
        }
    }
}
