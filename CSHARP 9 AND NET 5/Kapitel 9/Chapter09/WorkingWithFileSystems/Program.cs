using System;
using System.IO; //Typer för att hantera filsystemet
using static System.Console;
using static System.Environment;
using static System.IO.Directory;
using static System.IO.Path;

namespace WorkingWithFileSystems
{
    class Program
    {
        static void Main(string[] args)
        {
            //OutputFileSystemInfo();
            // WorkingWithDrives();
            //WorkWithDirectories();

            WorkWithFiles();
        }

        private static void WorkWithFiles()
        {

            //Definera en filväg till utmatning av filer
            //Börja med användarens mapp
            var dir = Combine(GetFolderPath(SpecialFolder.Personal), "Kod", "Kapitel9", "UtmatningsFiler");
            CreateDirectory(dir);

            //Definera filvägar
            string textFile = Combine(dir, "Dum.txt");
            string backupFile = Combine(dir, "Dum.bak");

            Console.WriteLine($"Jobbar med {textFile}");

            //Kollar om filen existerar
            Console.WriteLine($"Existerar filen? {File.Exists(textFile)}");

            //Skapar en ny textfil och skriver in till den
            StreamWriter sw = File.CreateText(textFile);

            sw.WriteLine("Abow knas!");
            sw.Close(); //Stänger och frigör resurser
            WriteLine($"Existerar filen? {File.Exists(textFile)}");

            //Kopierar och skriver över filen om den redan existerar
            File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite: true);
            Console.WriteLine($"Existerar backup filen? {File.Exists(backupFile)}");

            File.Delete(textFile);
            WriteLine($"Existerar filen? {File.Exists(textFile)}");


            //Läser upp text från backupen
            WriteLine($"Läster upp innehållet av {backupFile}:");
            StreamReader bF = File.OpenText(backupFile);
            WriteLine(bF.ReadToEnd());
            bF.Close();

            //Hanterar vägar
            WriteLine($"Mapp Namn: {GetDirectoryName(textFile)}");
            WriteLine($"Fil Namn: {GetFileName(textFile)}");
            WriteLine($"Fil Namn utan tillägg: {GetFileNameWithoutExtension(textFile)}");
            WriteLine($"Fil Namn med tillägg: {GetExtension(textFile)}");
            WriteLine($"Random Fil Namn: {GetRandomFileName()}");
            WriteLine($"Temporärt Fil Namn: {GetTempFileName()}");

            var info = new FileInfo(backupFile);

            WriteLine($"{backupFile}");

            Console.WriteLine($"Innehåller {info.Length} bytes");
            Console.WriteLine($"Senast åtkomst {info.LastAccessTime}");
            Console.WriteLine($"Har readonly satt till {info.IsReadOnly}");

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
       "NAMN", "TYP", "FORMAT", "STORLEK (BYTES)", "LEDIGT UTRYMME");

            foreach (DriveInfo drive in DriveInfo.GetDrives())
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
