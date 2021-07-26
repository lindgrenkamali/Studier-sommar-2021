using System;
using SharedLibrary;
namespace DotNetCoreEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jag kan köras överallt!");

            Console.Write("Skriv in en färg i hexadecimal: ");
            string hex = Console.ReadLine();
            Console.WriteLine($"Är {hex} en gitlig hexadecimal färg? {hex.IsValidHex()}");

            Console.Write("Skriv in ett XML element: ");
            string xmlTag = Console.ReadLine();
            Console.WriteLine($"Är {xmlTag} ett gitligt XML element? {xmlTag.IsValidXMLTag()}");

            Console.Write("Skriv in ett lösenord på fler tecken än 8: ");
            string password = Console.ReadLine();
            Console.WriteLine($"Är {password} gitligt? {password.IsValidPassword()}");
        }
    }
}
