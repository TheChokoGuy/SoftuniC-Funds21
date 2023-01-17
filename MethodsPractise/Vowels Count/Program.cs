using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            Console.WriteLine(VowelsInWord(word));
        }

        static int VowelsInWord(char[] word)
        {
            int vowels = 0;
            char[] vowelChars = {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < word.Length; i++)
            {
                for (int x = 0; x < vowelChars.Length; x++)
                {
                    if(word[i] == vowelChars[x])
                    {
                        vowels++;
                    }
                }
            }
            return vowels;
        }
    }
}
