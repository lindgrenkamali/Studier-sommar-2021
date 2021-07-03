using System;
using System.Collections;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 3;

            //while (x < 13)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}

            //string password = "tjena";

            //int i = 0;

            //do
            //{
            //    if (i < 10)
            //    {
            //        Console.Write("Skriv in ditt lösenord: ");
            //        password = Console.ReadLine();
            //        i++;
            //    }

            //    else
            //    {
            //        Console.WriteLine("Du är utelåst (:");
            //    }

            //} while (password != "tjena" );

            //Console.WriteLine("Excellento!");

            //for (int y = 0; y <= 10; y++)
            //{
            //    Console.WriteLine(y);
            //}

            string[] namn = { "David", "Fredrik", "Johan", "Nils" };

            foreach (string n in namn)
            {
                Console.WriteLine($"{n} har {n.Length} bokstäver i sitt namn");
            }

            IEnumerator e = namn.GetEnumerator();

            while(e.MoveNext())
            {
                string n = (string)e.Current; //Är readonly
                Console.WriteLine($"{n} har  {n.Length} bokstäver i sitt namn");
            }
        }
    }
}
