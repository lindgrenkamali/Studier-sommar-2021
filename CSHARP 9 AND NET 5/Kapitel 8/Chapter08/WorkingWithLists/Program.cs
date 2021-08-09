using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //SomeCities();
            ImmutableList();
        }

        private static void ImmutableList()
        {
            var cities = new List<string>();
            cities.Add("Stockholm");
            cities.Add("Köpenhamn");
            cities.Add("Oslo");
            cities.Add("Frankfurt");

            var immutableCities = cities.ToImmutableList();

            var newList = immutableCities.Add("Rinkeby");

            Console.WriteLine("Immutable lista av städer");
            foreach (string stad in newList)
            {
                Console.WriteLine(stad);
            }
        }

        private static void SomeCities()
        {
            
            var cities = new List<string>();
            cities.Add("Stockholm");
            cities.Add("Köpenhamn");
            cities.Add("Oslo");
            cities.Add("Frankfurt");

            foreach (string stad in cities)
            {
                Console.WriteLine(stad);
            }

            Console.WriteLine($"Den första staden är: {cities[0]}");

            Console.WriteLine($"Den sista staden är: {cities[cities.Count-1]}");

            cities.Insert(0, "Berlin");

            Console.WriteLine("Efter att ha lagt Berlin på första plats");

            foreach (string stad in cities)
            {
                Console.WriteLine(stad);
            }

            cities.RemoveAt(2);

            cities.Remove("Stockholm");

            Console.WriteLine("Efter att ha tagit bort två städer");

            foreach (string stad in cities)
            {
                Console.WriteLine(stad);
            }
        }
    }
}
