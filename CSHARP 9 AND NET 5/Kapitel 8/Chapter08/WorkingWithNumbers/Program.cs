using System;
using System.Numerics;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           // BigValues();
           
            //ComplexNumbers();
        }

        private static void BigValues()
        {
            var largest = ulong.MaxValue;
            Console.WriteLine($"{largest,40:N0}");

            var atomsInTheUniverse = BigInteger.Parse("123456789012345678901234567890");
            Console.WriteLine($"{atomsInTheUniverse,40:N0}");
        }

        private static void ComplexNumbers()
        {
            var x1 = new Complex(5, 3);
            var x2 = new Complex(4, 8);
            var x3 = x1 + x2;

            Console.WriteLine($"{x1} + {x2} = {x3}");
        }
    }
}
