using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Phone_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while(input != "End")
            {
                List<string> tokens = input.Split().ToList();
                switch(tokens[0])
                {
                    case "Add":
                        phones = Add(phones, tokens[2]);
                        break;
                    case "Remove":
                        phones = Remove(phones, tokens[2]);
                        break;
                    case "Last":
                        phones = Last(phones, tokens[2]);
                        break;
                    default:
                        string value = tokens[3];
                        List<string> values = value.Split(":").ToList();
                        phones = BonusPhone(phones, values[0], values[1]);
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", phones));
        }
        static List<string> Add(List<string> list, string value)
        {
            List<string> newList = list;
            bool isPhoneHere = false;
            for (int i = 0; i < newList.Count; i++)
            {
                if(newList[i] == value)
                {
                    isPhoneHere = true;
                    break;
                }
            }
            if(!isPhoneHere)
            {
                newList.Add(value);
            }
            return newList;
        }

        static List<string> Remove(List<string> list, string value)
        {
            List<string> newList = list;
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] == value)
                {
                    newList.Remove(value);
                }
            }
            return newList;
        }

        static List<string> BonusPhone(List<string> list, string oldPhone, string newPhone)
        {
            List<string> newList = list;
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] == oldPhone)
                {
                    newList.Insert(i + 1, newPhone);
                    break;
                }
            }
            return newList;
        }

        static List<string> Last(List<string> list, string value)
        {
            List<string> newList = list;
            for (int i = 0; i < newList.Count; i++)
            {
                if (newList[i] == value)
                {
                    string phone = newList[i];
                    newList.RemoveAt(i);
                    newList.Add(phone);
                    break;
                }
            }
            return newList;
        }

    }
}
