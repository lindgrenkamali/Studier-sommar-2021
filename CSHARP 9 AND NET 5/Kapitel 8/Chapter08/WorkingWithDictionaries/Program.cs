using System;
using System.Collections.Generic;

namespace WorkingWithDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionariesExamples();

            
        }

        private static void DictionariesExamples()
        {
            var keywords = new Dictionary<string, string>();
            keywords.Add("int", "32-bitar lång datatyp");
            keywords.Add("long", "64-bitar int datatyp");
            keywords.Add("float", "Ensam precisions floating pek nummer?");
            Console.WriteLine("Keywords och deras definitioner");

            foreach (KeyValuePair<string, string> item in keywords)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine($"Definitionen av keywordet lång är {keywords["long"]}");
        }
    }
}
