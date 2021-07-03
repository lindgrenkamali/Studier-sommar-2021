using System;

using static System.Console;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //a++ executes efter assignment
            int a = 5;
            int b = a++;
            WriteLine($"a är {a} och b är {b}");

           
            int c = 5;
            int d = ++c;//increment c before assigning it
            WriteLine($"c är {c} och d är {d}");


            int e = 13;

            int f = 7;

            WriteLine($"e är {e} och f är {f}");
            WriteLine($"e + f = {e + f}");
            WriteLine($"e - f = {e - f}");
            WriteLine($"e * f = {e * f}");
            WriteLine($"e / f = {e / f}");
            WriteLine($"e % f = {e % f}");

            double g = 11.0;
            WriteLine($"g är {g:N1} och f är {f}");
            WriteLine($"g / f = {g / f}");
        }
    }
}
