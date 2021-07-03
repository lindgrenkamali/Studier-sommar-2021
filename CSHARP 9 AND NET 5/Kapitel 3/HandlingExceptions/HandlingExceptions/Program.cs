using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Innan parsing");
            Console.Write("Vad är din ålder?");

            string input = ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"Du är {age} år gammal");
            }
            catch(OverflowException)
            {
                Console.WriteLine("För stort eller för litet nummer (:");
            }
            catch(FormatException)
            {
                Console.WriteLine("Bara bokstäver är tillåtna!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
                
            }
            Console.WriteLine("Efter parsing");
                
        }
    }
}
