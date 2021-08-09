using System;

namespace WorkingWithText
{
    class Program
    {
        static void Main(string[] args)
        {
            //City();
            //Cities();
            //PartOfString();

            //StartsWith();

            Formatting();

        }

        private static void Formatting()
        {
            string fruit = "Äpplen";
            decimal price = 13;

            DateTime when = DateTime.Today;

            Console.WriteLine($"{fruit} kostar {price} på {when:dddd}");
        }

        private static void StartsWith()
        {
            string company = "Apple";
            bool startWithA = company.StartsWith("A");
            bool containsÖ = company.Contains("Ö");
            Console.WriteLine($"Börjar med ett A: {startWithA}, innehåller ett Ö: {containsÖ}");
        }

        public static void PartOfString()
        {
            string fullName = "Grant Gustin";
            int indexOfTheSpace = fullName.IndexOf(" ");

            //Tar hela fram till mellanslaget
            string firstName = fullName.Substring(startIndex: 0, length: indexOfTheSpace);

            //Tar allt efter mellanslaget
            string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);

            Console.WriteLine(firstName + " " + lastName);

        }

        private static void Cities()
        {
            string cities = "Sverige,Norge,Danmark,Finland";

            string[] citiesArray = cities.Split(",");

            foreach (var city in citiesArray)
            {
                Console.WriteLine(city);
            }

            string recombined = string.Join(" => ", citiesArray);
            Console.WriteLine(recombined);
        }

        private static void City()
        {
            string city = "Metropolis";
            Console.WriteLine($"{city} är {city.Length} bokstäver långt.");

            Console.WriteLine($"Första och sista bokstav i {city} är {city[0]} och {city[city.Length - 1]}");
        }
    }
}
