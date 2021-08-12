using System;
using System.Text;

using static System.Console;

namespace WorkingWithEncodings
{
    class Program
    {
        static void Main(string[] args)
        {
            Encodings();
        }

        private static void Encodings()
        {
            Console.WriteLine("Encondings");
            Console.WriteLine("[1] ASCII");
            Console.WriteLine("[2] UTF-7");
            Console.WriteLine("[3] UTF-8");
            Console.WriteLine("[4] UTF-16 (UNICODE)");
            Console.WriteLine("[5] UTF-32");
            Console.WriteLine("[]Default");

            //Välj encoding
            Write("Skriv ett nummer 1-5");
            ConsoleKey number = ReadKey(intercept: false).Key;
            WriteLine("\n");

            Encoding encoder = number switch
            {
                ConsoleKey.D1 => Encoding.ASCII,
                ConsoleKey.D2 => Encoding.UTF7,
                ConsoleKey.D3 => Encoding.UTF8,
                ConsoleKey.D4 => Encoding.Unicode,
                ConsoleKey.D5 => Encoding.UTF32,
               _  => Encoding.Default

            };

            //Definera en sträng att encoda
            string message = "Monster nom nom?";

            //Encodar strängen
            byte[] encoded = encoder.GetBytes(message);

            //Kollar hur många bytes som encoded behöver
            Console.WriteLine($"{encoder.GetType()}, {encoded.Length}");

            //Enumerera genom varje byte
            Console.WriteLine($"Byte hex char");

            foreach (byte b in encoded)
            {
                WriteLine($"{b,4} {b.ToString("X"),4} {(char)b,5}");
            }

            string decoded = encoder.GetString(encoded);
            WriteLine(decoded);
        }
    }
}
