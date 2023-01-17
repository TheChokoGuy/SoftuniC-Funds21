using System;
using System.Linq;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = new string(username.ToCharArray().Reverse().ToArray());

            int count = 0;
            string input = Console.ReadLine();
            while(input != password)
            {
                count++;
                if(count > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine($"Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            if(count < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
