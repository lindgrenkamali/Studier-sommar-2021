#nullable enable
using System;

namespace NullHandling
{

    class Adress
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public String Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int thisCannotBeNull = 4;
            //thisCannotBeNull = null; //Komplireingsfel

            int? thisCanBeNull = null;
            Console.WriteLine(thisCanBeNull);
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());

            thisCanBeNull = 13;
            Console.WriteLine(thisCanBeNull);
            Console.WriteLine(thisCanBeNull.GetValueOrDefault());

            Adress adress = new();

            adress.Building = null;

            adress.Street = null;
            adress.City = null;
            adress.Region = null;

            //Kollar om variabeln är null innan användning
            //if (thisCanBeNull != null)
            //{
            //    int length = thisCanBeNull.Length;//Kan throwa ett exception
            //}

            string authorName = null;

            //Throwar ett nullreferenceexception
            //int x = authorName.Length;

            //Istället för att throwa, så får y värdet null
            int? y = authorName?.Length;

            //Resultatet blir 3 of authorName?.Length är null
            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);

        }
    }
}
