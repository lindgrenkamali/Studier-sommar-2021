using System;

//Slipper skriva Console hela tiden
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 12;
            decimal PricePerApple = 0.22M;

            WriteLine(format: "{0} äpplen kostar {1:C}", arg0: numberOfApples, arg1: PricePerApple * numberOfApples);

            string formatted = string.Format("{0} äpplen kostar {1:C}", arg0: numberOfApples, arg1: PricePerApple * numberOfApples);

            //WriteToFile(formatted); //Writes the string into a file

            WriteLine($"{numberOfApples} äpplen kostar {PricePerApple * numberOfApples:C}");

            string applesText = "Äpplen";
            int applesCount = 3123;

            string bananasText = "Bananer";
            int bananasCount = 4125;

            WriteLine(
                format: "{0, -8} {1,6:N0}", arg0: "Namn", arg1: "Antal");

            WriteLine(
                format: "{0,-8} {1,6:N0}", arg0: applesText, arg1: applesCount);

             WriteLine(
                format: "{0,-8} {1,6:N0}", arg0: bananasText, arg1: bananasCount);

            // Write("Skriv in ditt första namn och tryck Enter: ");

            //string firstName = ReadLine();

            //Write("Skriv in din ålder och tryck Enter: ");
            //string age = ReadLine();

            //WriteLine($"Hej {firstName} du ser bra ut för att vara {age} år.");

            Write("Tryck en knapp kombination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);




        }
    }
}
