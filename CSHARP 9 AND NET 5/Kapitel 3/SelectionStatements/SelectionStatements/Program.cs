using System;
using System.IO;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Inga argument");
            }

            else
            {
                Console.WriteLine("Det finns åtminstone ett argument");
            }

            //Lägg till och ta bort "" för att ändra beteende
            object o = 3;
            int j = 4;

            if (o is int i)
            {
                Console.WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                Console.WriteLine("o is not an int so it cannot multiply");
            }

        A_label:
            var nummer = (new Random()).Next(1, 13);
            Console.WriteLine($"Mitt slumpmässiga tal är {nummer}");
            switch (nummer)
            {
                case 1:
                    Console.WriteLine("Ett");
                    break;
                case 2:
                    Console.WriteLine("Två");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Tre eller fyra");
                    goto case 1;

                //Går i vilo en halvsekund
                case5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    Console.WriteLine("Över 5 men under 14");
                    break;
            }

            string path = @"C:\Users\david\";

            Console.Write("Tryck R för readonly eller W för att skriva");

            ConsoleKeyInfo key = Console.ReadKey();

            Console.WriteLine();

            Stream s = null;

            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read);
            }

            else if (key.Key == ConsoleKey.W)
            {
                s = File.Open(Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write);
            }

            string message = string.Empty;

            //switch(s)
            //{
            //    case FileStream writeableFile when s.CanWrite:
            //        message = "The stream is a file that I can write to.";
            //        break;

            //    case FileStream readOnlyFile:
            //        message = "The stream is a read-only file";
            //            break;
            //    case MemoryStream ms:
            //        message = "The stream is a memory adress";
            //        break;
            //    default:
            //        message = "The stream is some other type.";
            //        break;
            //    case null:
            //        message = "The stream is null";
            //        break;
            //}
            //Console.WriteLine(message);
            message = s switch
            {
                FileStream writeableFile when s.CanWrite
                    => "The stream is a file that I can write to.",


                FileStream readOnlyFile
                    => "The stream is a read-only file",

                MemoryStream ms
                         => "The stream is a memory adress",

                null
            => "The stream is null",

                _
                   => "The stream is some other type."




            };
            Console.WriteLine(message);
        }
    }
}
