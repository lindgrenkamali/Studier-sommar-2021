using System; //Datetime
using System.Collections.Generic;
using System.Xml.Serialization; //XMLserializer
using System.IO; //Filestream så som reader och writer
using static System.Console;
using static System.Environment;
using static System.IO.Path;
using System.Threading.Tasks;
using NuJson = System.Text.Json.JsonSerializer;

namespace WorkingWithSerialization
{

    class Program
    {
        public static List<Person> people = new List<Person>
            {
                new Person(32000M) {FirstName = "Christopher", LastName = "Smith", DateOfBirth = new DateTime(1977, 4, 23) },
                new Person(40000M) {FirstName ="Rick", LastName= "Flag", DateOfBirth= new DateTime(1979, 11, 25)},
                new Person(48000M) {FirstName ="Robert", LastName= "DuBois", DateOfBirth= new DateTime(1972, 09, 6),
                    Children = new HashSet<Person> {new Person (0M) {FirstName = "Tyla", LastName= "Dubois", DateOfBirth= new DateTime(2003, 7, 1)}
            } } };

        static async Task Main(string[] args)
        {
            
            //ObjectGraph();
            await JsonThing();

        }

        private static async Task JsonThing()
        {


            //Skapar en fil att skriva till
            string jsonPath = Combine(CurrentDirectory, "jsonMänniskor.json");

            using (StreamWriter jsonStream = File.CreateText(jsonPath))
            {
                //Skapar ett objekt som formateras som JSON
                var jss = new Newtonsoft.Json.JsonSerializer();

                //Serialiserar objekt grafen till en sträng
                jss.Serialize(jsonStream, people);
            }

            WriteLine($"Skrivit {new FileInfo(jsonPath).Length} bytes av JSON till {jsonPath}");

            //Visar den serializerade objekt grafen
            WriteLine(File.ReadAllText(jsonPath));

            using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
            {
                //Deserializera objekt graf till en lista av personer
                var loadedPeople = (List<Person>)
                    await NuJson.DeserializeAsync(utf8Json: jsonLoad, returnType: typeof(List<Person>));

                foreach (var p in loadedPeople)
                {
                    WriteLine($"{p.FirstName + " " + p.LastName} har {p.Children?.Count ?? 0} antal barn");
                }
            }

            
        }

        private static void ObjectGraph()
        {
            //Create an object graph

            //Skapar ett objekt som kommer formatera en lista av Personer som XML
            var xs = new XmlSerializer(typeof(List<Person>));

            //Skapar en fil att skriva till
            string path = Combine(CurrentDirectory, "människor.xml");


            using (FileStream stream = File.Create(path))
            {
                //serializerar objekt graphen till strömmen
                xs.Serialize(stream, people);

            }

            WriteLine($"Skrivit {new FileInfo(path).Length} bytes av XML till {path}");

            //Skriv ut den serialisera objekt grafen
            WriteLine($"\n{File.ReadAllText(path)}");

            using (FileStream xmlLoad = File.Open(path, FileMode.Open))
            {
                //deserialize och kasta objekt grafen till en lista av person
                {
                    var loadedPeople = (List<Person>)xs.Deserialize(xmlLoad);
                    foreach (var p in loadedPeople)
                    {
                        WriteLine($"{p.FirstName+ " " + p.LastName} har {p.Children.Count} antal barn");
                    }
                }
            }
        }
    }
}
