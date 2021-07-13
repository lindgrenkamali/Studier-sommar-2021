using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    public class ImmutablePerson
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
    }

    public record ImmutableVehicle
    {
        public int Wheels { get; init; }
        public string Color { get; init; }

        public string Brand { get; init; }
    }

    //public record Person
    //{
    //    int Age; //public propery equivalent to
    //    //public int Age {get; init;}

    //}

    //Enklare väg att definera recordet som gör equivalent
    public record ImmutableAnimal2(string Name, string Species);

    public record ImmutableAnimal
    {
        string Name; //public init-only properties
        string Species;


        public ImmutableAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public void Deconstruct(out string name, out string species)
        {
            name = Name;
            species = Species;
        }
    }

    
}
