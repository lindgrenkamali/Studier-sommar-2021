using System;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine($"AND  | a    b ");
            Console.WriteLine($" a   | {a & a, -5} | {a & b, -5} ");
            Console.WriteLine($"b    | {b & a,-5}  | {b & b, -5} ");
            Console.WriteLine();
            Console.WriteLine($"OR   | a     | b ");
            Console.WriteLine($"a    | {a | a,-5} | {a | b,-5}");
            Console.WriteLine($"a    | {b | a,-5} | {b | b,-5}");
            Console.WriteLine();
            Console.WriteLine($"XOR  | a   | b ");
            Console.WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
            Console.WriteLine($"a    | {b ^ a,-5} | {b ^ b,-5} ");


            //DoStuff() körs alltid
            Console.WriteLine($"a & DoStuff() = {a & DoStuff()}");
            Console.WriteLine($"b & DoStuff() = {b & DoStuff()}");

            //DoStuff körs bara när det andra värdet också är true
            Console.WriteLine($"a && DoStuff() = {a && DoStuff()}");
            Console.WriteLine($"b && DoStuff() = {b && DoStuff()}");
        }

        private static bool DoStuff()
        {
            Console.WriteLine("Jag gör saker");
            return true;
        }
    }
}
