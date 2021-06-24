using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Osignerad int är ett helt nummer
            uint helNummer = 13_000;

            //Int är negativt eller positivt
            int intNummer = -4;

            //float är single precision
            float ensam = 1.3F;

            //double är dubbel precision
            double dubbel = 1.3;

            //Tre variabler som har värdet 2 miljoner
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            //Jämför alla tre notationer
            System.Console.WriteLine($"{hexadecimalNotation == decimalNotation && decimalNotation == binaryNotation}");

            //Storlekar på variabler
            System.Console.WriteLine($"int använder {sizeof(int)} bytes och kan lagra nummer i storleken från {int.MinValue} till {int.MaxValue}");
            System.Console.WriteLine($"double använder {sizeof(double)} bytes och kan lagra nummer i storleken från {double.MinValue} till {double.MaxValue}");
            System.Console.WriteLine($"float använder {sizeof(float)} bytes och kan lagra nummer i storleken från {float.MinValue} till {float.MaxValue}");
            System.Console.WriteLine($"decimal använder {sizeof(decimal)} bytes och kan lagra nummer i storleken från {decimal.MinValue} till {decimal.MaxValue}");

            System.Console.WriteLine("\n Använder dubbel");
            double x = 0.1;
            double y = 0.7;

            if (x + y == 0.8)
            {
                System.Console.WriteLine(x+y + " är 0.8");
            }
            else
            {
                System.Console.WriteLine(x + y +" är inte 0.8");
            }

            System.Console.WriteLine("\n Använder decimal");
            decimal g = 0.1M;
            decimal r = 0.7M;

            if (r + g == 0.8M)
            {
                System.Console.WriteLine(g+r + " är 0.8");
            }
            else
            {
                System.Console.WriteLine(g + r +" är inte 0.8");
            }
        }
    }
}
