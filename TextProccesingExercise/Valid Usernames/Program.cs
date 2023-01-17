using System;
using System.Collections.Generic;
using System.Linq;
namespace ТеxtProccesingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (var username in usernames)
            {
                if (username.Length > 3 && username.Length <= 16)
                {
                    bool isValid = true;
                    foreach (char letter in username)
                    {
                        if (!(char.IsLetterOrDigit(letter) || letter == '-' || letter == '_'))
                        {
                            isValid = false;
                            break;
                        }
                        
                    }

                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}