using System;

namespace CheckingForOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;

                    Console.WriteLine($"Ursprungliga värdet: {x}");
                    x++;
                    Console.WriteLine($"Efter inkrementering: {x}");
                    x++;
                    Console.WriteLine($"Efter inkrementering: {x}");
                    x++;
                    Console.WriteLine($"Efter inkrementering: {x}");
                }
                unchecked
                {

                    int y = int.MaxValue + 1;

                    Console.WriteLine($"Ursprungliga värdet: {y}");
                    y++;
                    Console.WriteLine($"Efter inkrementering: {y}");
                    y++;
                    Console.WriteLine($"Efter inkrementering: {y}");
                    y++;
                    Console.WriteLine($"Efter inkrementering: {y}");

                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Koden overflowade men jag fångade ett exception");
            }
        }
    }
}
