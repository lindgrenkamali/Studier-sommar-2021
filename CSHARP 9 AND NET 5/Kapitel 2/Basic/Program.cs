using System;
using System.Linq;
using System.Reflection;

// #error version

namespace Basic
{
    class Program
    {

        //+ är operator och variablerna om höger är operander
        //var totalPris = subTotal + salesSkatt
        static void Main(string[] args)
        {
            //Typer som ej används
            System.Data.DataSet dataSet;
            System.Net.Http.HttpClient client;

            Console.WriteLine("Hello World!");

            //Skriver ut en carriage return
            Console.WriteLine("");

            //Skriver ut en hälsning och en carriage return
            Console.WriteLine("Hej Brufors!");

            //Skriver ut ett formaterat nummer och datum och en carriage return
            Console.WriteLine("Temperatur den {0:D} är {1} grad celsius", DateTime.Today, 21.6);

            //Loopar igenom alla assemblies som appen refenserar
            foreach (var item in Assembly.GetEntryAssembly().GetReferencedAssemblies())
            {
                //Laddar assembliet så man kan se detaljerna
                var assem = Assembly.Load(new AssemblyName(item.FullName));

                //Räknar antalet nummer av metoder
                int metodRäknare = 0;

                //Loopar alla typer i ett assembly
                foreach (var typer in assem.DefinedTypes)
                {
                    metodRäknare += typer.GetMethods().Count();
                }

                //Utskrift för antalet typer och deras metoder
                System.Console.WriteLine("{0:N0} typer med {1:N0} metoder i {2} assembly", assem.DefinedTypes.Count(), metodRäknare, item.Name);


            }

            double höjdIMeter = 1.88;
            //Skriver ut datatypensnamn
            System.Console.WriteLine($"Variabeln {nameof(höjdIMeter)} har värdet {höjdIMeter}");

            //Literal värden
            char bokstav = 'B';
            char siffra = '3';
            char symbol = '?';

            string förNamn = "Ben"; 
            string efterNamn = "Affleck";
            string mobilNummer = "0720329482";
            
            string fullNamnMedTabSeparator = "Ben\tAffleck";

            string filePath = @"C:\Program\Blizzard\Overwatch";

            // // char användarVal = GetKeystroke(); //Från funktion


        }
    }
}
