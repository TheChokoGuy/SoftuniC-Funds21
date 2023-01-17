using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar == '>')
                {
                    if (int.Parse(input[i + 1].ToString()) == 1)
                    {
                        input = input.Remove(i + 1, 1);
                    }
                    else
                    {
                        int explosion = int.Parse(input[i + 1].ToString());
                        for (int j = i + 1; j <= i + explosion; j++)
                        {
                            currChar = input[j];
                            if (currChar == '>')
                            {
                                explosion += int.Parse(input[j + 1].ToString());
                            }
                            
                        }

                        for (int x = 0; x < explosion; x++)
                        {
                            currChar = input[i + 1];
                            if (currChar != '>')
                            {
                                input = input.Remove(i + 1, 1);
                            }
                            else
                            { 
                                explosion++;
                            }
                        }
                    }
                }

            }

            Console.WriteLine(input);               

        }
    }
}