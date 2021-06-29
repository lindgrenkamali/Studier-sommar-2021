using System;
using static System.Console;

namespace Arguments
{
    class Program
    {

        //Terminal dotnet run firstarg second-arg third:arg "fourth arg"
        static void Main(string[] args)
        { 

            WriteLine($"Det finns {args.Length} arguments.");

            foreach (string arg in args)
            {
                WriteLine(arg);
            }

            if (args.Length < 3)
            {
                WriteLine("Du måste specificera två färger och en cursor size, e.g");
                WriteLine("dotnet run red yellow 50");
                return; //Slutar köra
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[0], ignoreCase: true);
            BackgroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor), value: args[1], ignoreCase: true);
            //CursorSize = int.Parse(args[2]);

            try
            {
                CursorSize = int.Parse(args[2]);
            }
            catch (PlatformNotSupportedException)
            {

                WriteLine("The current platform does not support changing the size of the cursor.");
                if (OperatingSystem.IsWindows())
                {
                    //Kör koden som bara funkar på Windows
                }
            }
        }
    }
}
