using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurences
{
    class OddOccurences
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            string[] data = input.Split(' ');

            Dictionary<string, int> pcLanguages = GetNeededDictionary(data);
            List<string> listOfKeys = GetOddOccurences(pcLanguages);
            Console.WriteLine(string.Join(", ", listOfKeys));
            
        }

        static List<string> GetOddOccurences(Dictionary<string, int> languages)
        {
            var listOfLanguages = new List<string>();

            foreach (var item in languages)
            {
                if (item.Value % 2 == 1)
                {
                    listOfLanguages.Add(item.Key);
                }
            }

            return listOfLanguages;
        }

        static Dictionary<string, int> GetNeededDictionary(string[] data)
        {
            var languages = new Dictionary<string, int>();
            foreach (var item in data)
            {
                if (languages.ContainsKey(item))
                {
                    languages[item]++;
                }
                else
                {
                    languages.Add(item, 1);
                }
            }

            return languages;
        }
    }
}
