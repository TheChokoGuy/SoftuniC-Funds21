using System;
using System.Text;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(input);

            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] splitCommand = command.Split("|");
                if (splitCommand[0] == "ChangeAll")
                {
                    result.Replace(splitCommand[1], splitCommand[2]);
                }
                else if (splitCommand[0] == "Insert")
                {
                    result.Insert(int.Parse(splitCommand[1]), splitCommand[2]);
                }
                else if (splitCommand[0] == "Move")
                {  
                    int number = int.Parse(splitCommand[1]);
                    string substring = result.ToString().Substring(0, number);
                    result.Remove(0, number);
                    result.Append(substring);
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {result}");
        }
    }
}