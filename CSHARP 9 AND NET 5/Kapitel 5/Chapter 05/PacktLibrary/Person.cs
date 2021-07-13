using System;
using System.Collections.Generic;


namespace PacktLibrary.Shared
{
    public partial class Person : object
    {
        //fields
        public string Name;

        //int Age //Private by default

        public DateTime DateOfBirth;

        public WondersOfTheAncientWonder FavoriteAncientWorld;

        public WondersOfTheAncientWonder BucketList;

        public List<Person> Children = new();

        //const
        public const string Species = "Homo Sapien";

        //read-only
        public readonly string HomePlanet = "Mars";
        public readonly DateTime Instantiated;

        

        public Person()
        {
            //sätt default värden på fält
            //inkluderar read-only
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }
        public (string name, int age) GetPerson()
        {
            return (name: this.Name, age: this.DateOfBirth.Year);
        }
            

        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} var född på en {DateOfBirth:dddd}");
        }

        public string GetOrigin()
        {
            return $"{Name} var född på planeten {HomePlanet}";
        }


        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Ananasar", Number: 13);
        }
        public string SayHello()
        {
            return $"{Name} säger 'HEJ!'";
        }

        public string SayHello(string name)
        {
            return $"{Name} säger 'HEJ' till {name}";
        }

        public string OptionalParameters(string command = "Spring!", double number = 1.1, bool active = false)
        {
            return $"Kommandot är {command}, nummer är {number}, aktiv är {active}";
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            //out parametrar kan inte ha default
            //och måste instanseras i metoden
            z = 399;

            //increment varje parameter
            x++;
            z++;
            y++;
        }

   
    }

   
    

    [System.Flags]
    public enum WondersOfTheAncientWonder : byte
    {
        None = 0b_0000_0000, //0

        GreatPyramidOfGiza = 0b_0000_0001, HangingGardensOfBabylon = 0b_0000_0010, StatueOfZeusAtOlympia = 0b_0000_0011, TempleOfArtemisAtEphesus = 0b_0000_0100, MausoleumAtHalicarnassus = 0b_0000_0101, ColossusOfRhodes = 0b_0000_0110, LighthouseOfAlexandria = 0b_0000_0111
    }
}
