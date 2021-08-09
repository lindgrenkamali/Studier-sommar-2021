using System;
using System.Globalization;

namespace Internalization
{
    class Program
    {
        static void Main(string[] args)
        {
            Cultures();
        }

        private static void Cultures()
        {
            CultureInfo globalization = CultureInfo.CurrentCulture;
            CultureInfo localization = CultureInfo.CurrentUICulture;

            Console.WriteLine($"Den nuvarande globala kulturen är {globalization.Name}, {globalization.DisplayName}");
            Console.WriteLine($"Den nuvarande lokaliseringskulturen är {localization.Name}, {localization.Name}");

            Console.WriteLine($"en-US: Engelska (USA)");
            Console.WriteLine($"da-DK: Danska (Danmark)");
            Console.WriteLine($"fr-CA: Franska (Kanada)");
            Console.Write("Skriv in en ISO kod: ");
            string newCulture = Console.ReadLine();

            if (!string.IsNullOrEmpty(newCulture))
            {
                var ci = new CultureInfo(newCulture);
                CultureInfo.CurrentCulture = ci;
                CultureInfo.CurrentUICulture = ci;
            }
            Console.Write("\nSkriv in ditt namn: ");
            string namn = Console.ReadLine();

            Console.Write("Skriv in din födelsedag: ");

            string daf = Console.ReadLine();

            Console.Write("Skriv in ditt saldo: ");
            string saldo = Console.ReadLine();

            DateTime date = DateTime.Parse(daf);

            int minuter = (int)DateTime.Today.Subtract(date).TotalMinutes;
            decimal lön = decimal.Parse(saldo);

            Console.WriteLine($"{namn} var född på en {daf:dddd}, är {minuter:N0} minuter gammal och tjänar {lön}");
        }
    }
}
