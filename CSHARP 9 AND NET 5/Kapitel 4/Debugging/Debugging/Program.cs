using System;

namespace Debugging
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            double a = 4.5; // eller använd var
            double b = 2.5;

            double answer = Add(a, b);
            Console.WriteLine($"{a} + {b} = {answer}");

            Console.ReadLine(); //Väntar på att användaren trycker ENTER
        }
    }
}
