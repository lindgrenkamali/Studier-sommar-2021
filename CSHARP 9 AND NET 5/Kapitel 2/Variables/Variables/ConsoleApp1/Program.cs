using System;
using System.IO;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.45; //Double i objekt

            object name = "Amanda"; //String i objekt

            Console.WriteLine($"{name} är {height} meter lång");

            //int length1 = name.Length; // Ger kompileringsfel

            int length2 = ((string)name).Length;//Säger till kompilatorn att det är en sträng

            Console.WriteLine($"{name} har {length2} bokstäver i sitt namn");

            //Lagrar en sträng i ett dynamiskt objekt
            dynamic andraNamn = "Lisa";

            //Det här kompileras men kommer kasta ett exception vid run-time
            //Om du senare lägger till en datatyp som inte har propertyn length
            int längd = andraNamn.Length;

            var befolkning = 53_000_000; //53 miljoner
            var vikt = 2.00; //i kilogram
            var pris = 5.00M; //miljoner
            var frukt = "Äpplen";//Strängar använder dubbel quotes
            var bokstav = 'C'; //Char använder enkel quotes
            var glad = false; //Booleaner är antingen true eller false

            //Bra användning av var för att den undviker återupprepning
            //Som visas i det mer verbose andra statementet
            var xml1 = new XmlDataDocument();
            XmlDocument xml2 = new XmlDocument();

            //Dålig användning av var eftersom vi inte kan se vilken typ det är
            //Så använd andra statementet istället för var
            //var file1 = File.CreateText(@"C:\something.txt");
            //StreamWriter file2 = File.CreateText(@"C:\something.txt");


            //Target type utan att visa vilken variabel det är i andra änden, las till i C# 9
            XmlDocument xml3 = new();


            Console.WriteLine($"default(int) = {default(int)}");

            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");


        }
    }
}
