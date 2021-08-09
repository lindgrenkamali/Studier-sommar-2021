using System;
using System.IO; //Typer för att hantera filsystemet
using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

namespace WorkingWithFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutputFileSystemInfo();
           // WorkingWithDrives();
            WorkWithDirectories();
        }

        static void WorkWithDirectories()
        {
            //Definera en filväg för en ny mapp
            //Börjar med användarens mapp
            var newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "Kod", "Kapitel9", "NyMapp");

            WriteLine($"Jobbar med: {newFolder}");

            //Kollar om den existerar
            WriteLine($"Exister filvägen? {Exists(newFolder)}");

            //Skapar filvägen
            WriteLine("Skapar den...");
            CreateDirectory(newFolder);

            WriteLine($"Finns filvägen verkligen? {Exists(newFolder)}");

            //Tar bort filvägen
            WriteLine("Tar bort den, lol");
            Delete(newFolder, recursive: true);

            WriteLine($"Exister filvägen? {Exists(newFolder)}");

        }

        static void WorkingWithDrives()
        {
            WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
       "NAMN", "TYP", "FORMAT", "STORLEK (BITAR)", "LEDIGT UTRYMME");

            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
                               drive.Name, drive.DriveType, drive.DriveFormat,
                               drive.TotalSize, drive.AvailableFreeSpace);
                }

                else
                {
                    WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);
                }
            }
        }

        static void OutputFileSystemInfo()
        {
            WriteLine("{0,-33} {1}", "Path.PathSeparator", PathSeparator);
            WriteLine("{0,-33} {1}", "Path.DirectorySeparatorChar",
              DirectorySeparatorChar);
            WriteLine("{0,-33} {1}", "Directory.GetCurrentDirectory()",
              GetCurrentDirectory());
            WriteLine("{0,-33} {1}", "Environment.CurrentDirectory",
              CurrentDirectory);
            WriteLine("{0,-33} {1}", "Environment.SystemDirectory", SystemDirectory);
            WriteLine("{0,-33} {1}", "Path.GetTempPath()", GetTempPath());
            WriteLine("GetFolderPath(SpecialFolder");
            WriteLine("{0,-33} {1}", "  .System)", GetFolderPath(SpecialFolder.System));
            WriteLine("{0,-33} {1}", "  .ApplicationData)",
              GetFolderPath(SpecialFolder.ApplicationData));
            WriteLine("{0,-33} {1}", "  .MyDocuments)",
              GetFolderPath(SpecialFolder.MyDocuments));
            WriteLine("{0,-33} {1}", "  .Personal)",
              GetFolderPath(SpecialFolder.Personal));
        }
    }
}
