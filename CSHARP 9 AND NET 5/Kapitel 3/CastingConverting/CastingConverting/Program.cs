using System;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 13;
            //double b = a; //En int kan säkert bli en double variabel

            //Console.WriteLine(b);

            //double c = 3.99;

            //int d = (int)c; //Kompilatorn ger ett fel
            //Console.WriteLine(d);//Information försvinner

            //long e = 11;
            //int f = (int)e;
            //Console.WriteLine($"e är {e:N0} och f är {f:N0}");
            //e = long.MaxValue;
            //e = 5_000_000_000;
            //f = (int)e;

            //Console.WriteLine($"e är {e} och f är {f}");

            //double g = 5.6;

            //int h = ToInt32(g);
            //Console.WriteLine($"g är {g} och h är {h}");

            //double[] dubletter = new[]
            //{
            //    9.42, 5.53, 6.43, 1.25, 46.4
            //};

            //foreach (double dublett in dubletter)
            //{
            //    Console.WriteLine($"ToInt({dublett}) är {ToInt32(dublett)}");
            //}

            //foreach (double dublett in dubletter)
            //{
            //    Console.WriteLine(format: "Math.Round({0}, 0, MidPointRounding.AwayFromZero) är {1}", arg0: dublett, arg1: Math.Round(value: dublett, digits: 0, mode: MidpointRounding.AwayFromZero));
            //}

            //int number = 13;

            //Console.WriteLine(number.ToString());

            //bool boolean = false;

            //Console.WriteLine(boolean.ToString());

            //DateTime now = new();
            //Console.WriteLine(now.ToString());

            //object me = new Object();
            //Console.WriteLine(me.ToString());


            ////Allokerar array med 128 bytes
            //byte[] binaryObject = new byte[128];

            ////Fyller med random bytes
            //(new Random()).NextBytes(binaryObject);

            //Console.WriteLine("Binära objekt som bytes");

            //for (int index = 0; index < binaryObject.Length; index++)
            //{
            //    Console.Write($"{binaryObject[index]:X}");
                
            //}


            ////Konverterar till Base64 sträng
            //string encoded = Convert.ToBase64String(binaryObject);

            //Console.WriteLine($"Binary Object som Base64: {encoded}");

            //int age = int.Parse("21");

            //DateTime birthday = DateTime.Parse("13 June 2000");

            //Console.WriteLine($"Jag är född {age} år sedan");
            //Console.WriteLine($"Min födelsedag är {birthday}");
            //Console.WriteLine($"Min födelsedag är {birthday:D}");


            //int count = int.Parse("xyz");

            Console.Write("Hur många ägg finns det: ");

            int count;

            string input = Console.ReadLine();

            if (int.TryParse(input, out count))
            {
                Console.WriteLine($"Det finns {count} antal ägg");
            }
            else
            {
                Console.WriteLine("Vad hände?");
            }


        }
    }
}
