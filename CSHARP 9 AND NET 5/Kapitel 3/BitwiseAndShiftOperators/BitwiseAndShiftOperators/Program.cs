using System;

namespace BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; //0000 1010
            int b = 6; //0000 0110

            
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");

            Console.WriteLine($"a & b = {a & b}"); //2-bit column only, då 2 är 1
            Console.WriteLine($"a | b = {a | b}"); //8, 4 and 2-bit column only, då 8,4,2 är 1
            Console.WriteLine($"a ^ b = {a ^ b}"); //8 and 4-bit column only, då 8 är 1 på b men inte a, och 4 är 1 på a men inte b

            //0101 0000 left-shift a by three bit columns
            Console.WriteLine($"a << 3 = {a << 3}");

            //Multiplicerar a med 8
            Console.WriteLine($"a * 8 = {a * 8}");

            //0000 0011 right-shift b by one column
            Console.WriteLine($"b >> 1 = {b >> 1}");

            int age = 50;

            //Hur många operatorer är det i
            char firstDigit = age.ToString()[0];

            //= assignment operator
            //. member access operator
            // () invocation operator
            // [] indexer access operator

            
        }
    }
}
