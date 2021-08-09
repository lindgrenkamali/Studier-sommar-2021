using System;
using System.Text.RegularExpressions;
namespace WorkingWithRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ChekingDigits();
            CheckingMovies();
        }

        private static void CheckingMovies()
        {
            string films = "\"Monsters, Inc.\",\"I, Tonya \",\"Lock, Stock and Two Smoking Barrels\"";
            string[] filmsDumb = films.Split(',');
            Console.WriteLine("Dumt försök att splitta:");
            foreach (var item in filmsDumb)
            {
                Console.WriteLine(item);
            }

            var csv = new Regex("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

            MatchCollection filmer = csv.Matches(films);

            Console.WriteLine($"Smart försök att splitta: ");
            foreach (Match film in filmer)
            {
                Console.WriteLine(film.Groups[2].Value);
            }
        }

        private static void ChekingDigits()
        {
            Console.Write("Skriv in din ålder: ");
            string age = Console.ReadLine();
            var ageChecker = new Regex(@"^\d+$");
            if (ageChecker.IsMatch(age))
            {
                Console.WriteLine("Tack!");
            }
            else
            {
                Console.WriteLine($"{age} är inte en gitlig ålder.");
            }
        }
    }
}
