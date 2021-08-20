using CryptographyLib;
using System;

using static System.Console;

namespace HashingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Registerar Albin med Lösenord.");
            var albin = Protector.Register("Albin", "Lösenord");

            WriteLine($"Namn: {albin.Name}");
            WriteLine($"Salt: {albin.Salt}");
            WriteLine($"Lösenord (saltat och hashat): {albin.SaltedHashedPassword}\n");

            Write("Skriv in en ny användare att registrera: ");
            string användarnamn = ReadLine();

            Write("Skriv in ett lösenord till kontot: ");
            string lösenord = ReadLine();

            var användare = Protector.Register(användarnamn, lösenord);

            WriteLine($"Namn: {användare.Name}");
            WriteLine($"Salt: {användare.Salt}");
            WriteLine($"Lösenord (saltat och hashat): {användare.SaltedHashedPassword}\n");

            bool correctPassword = false;

            while (!correctPassword)
            {
                Write("Skriv in ditt användarnamn: ");
                string inloggningsAnvändarnamn = ReadLine();

                Write("Skriv in lösenordet till det associerade kontot: ");
                string inloggningsLösenord = ReadLine();

                correctPassword = Protector.CheckPassword(inloggningsAnvändarnamn, inloggningsLösenord);

                if (correctPassword)
                {
                    WriteLine("Du har loggats in!");
                }
                else
                {
                    WriteLine("Fel lösenord eller användarnamn, försök igen");
                }
            }

        }
    }
}
