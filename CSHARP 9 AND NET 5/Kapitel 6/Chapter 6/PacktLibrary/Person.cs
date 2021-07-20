using System;
using System.Collections.Generic;


namespace PacktLibrary.Shared
{
    public class Person : IComparable<Person>
    {
        //fält
        public string Name;

        public DateTime DateOfBirth;

        public List<Person> Children = new();

        //Metoder
        public void WriteToConsole()
        {
            Console.WriteLine($"{Name} var född på en {DateOfBirth:dddd}.");
        }

        //Statisk metod för att utöka
        public static Person ProCreate(Person p1, Person p2)
        {
            var child = new Person
            {
                Name = $"Barn av {p1.Name} och {p2.Name}"
            };

            p1.Children.Add(child);
            p2.Children.Add(child);
            return child;

        }

        //instans metod för att utöka
        public Person ProCreateWith(Person partner)
        {
            return ProCreate(this, partner);
        }

        //operator som förökar
        public static Person operator *(Person p1, Person p2)
        {
            return Person.ProCreate(p1, p2);
        }

        //Metod med en lokal funktion
        public static int Factorial(int number)
        {
            if (number < 2)
            {
                throw new ArgumentException($"{nameof(number)} kan inte ha ett värde under 2");
                
            }
            return localFactorial(number);

            //Lokal funktion
            int localFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * localFactorial(localNumber - 1);
            }
        }

        //Event delegate field
        public event EventHandler Shout;

        //Data field
        public int AngerLevel;

        public void Poke()
        {
            AngerLevel++;

            if (AngerLevel >= 3)
            {
                //Om någonting lyssnar
                if (Shout != null)
                {
                    //Kalla på delegaten
                    Shout(this, EventArgs.Empty);
                }
            }
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"{Name} är en {base.ToString()}";
        }

        public void TimeTravel(DateTime when)
        {
            if (when <= DateOfBirth)
            {
                throw new PersonException("Om du reser tillbaka i tiden till en dag före din födelse, så kommer universum explodera!");
            }

            else
            {
                Console.WriteLine($"Välkommen till {when:yyyy}!");
            }
        }
    }
}
        

 