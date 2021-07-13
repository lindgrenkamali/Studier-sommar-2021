using PacktLibrary.Shared;
using System;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //    var gunvald = new Person("Gunvald Larsson", "Jorden");

            //    var blankPerson = new Person();
            //    Console.WriteLine($"{blankPerson.Name} av {Person.Species} skapades {blankPerson.Instantiated:hh:mm:ss} på en {blankPerson.Instantiated:dddd}");

            //    var bang = new Person();
            //    bang.Name = "Alexander Bang";

            //    bang.Children.Add(new Person {Name =  "Tuong" });
            //    bang.Children.Add(new Person { Name = "Essa" });

            //    bang.DateOfBirth = DateTime.Now;
            //    bang.FavoriteAncientWorld = WondersOfTheAncientWonder.GreatPyramidOfGiza;
            //    bang.BucketList = WondersOfTheAncientWonder.MausoleumAtHalicarnassus | WondersOfTheAncientWonder.StatueOfZeusAtOlympia;
            //    Console.WriteLine(bang.ToString());

            //    Console.WriteLine($"{bang.Name} är en {Person.Species} and is living on {bang.HomePlanet}");
            //    Console.WriteLine(format: "{0} föddes {1:dddd, d MMMM yyyy}, hans favoritstaty har nummer {2}", arg0: bang.Name, arg1: bang.DateOfBirth, arg2: (int)bang.FavoriteAncientWorld);
            //    Console.WriteLine($"Han ska dock kolla på {bang.BucketList} imorgon");

            //    Console.WriteLine($"{bang.Name} har {bang.Children.Count} barn som heter:");
            //    foreach (var item in bang.Children)
            //    {
            //        Console.WriteLine(item.Name);
            //    }

            //    Console.WriteLine();
            //    var anna = new Person
            //    {
            //        Name = "Anna Johansson",
            //        DateOfBirth = new DateTime(2000, 3, 19)
            //    };

            //Console.WriteLine(format: "{0} föddes {1:dddd, d MMMM yyyy}", arg0: anna.Name, arg1: anna.DateOfBirth);

            //    BankAccount.InterestRate = 0.012M;

            //    var jonasKonto = new BankAccount();

            //    jonasKonto.AccountName = "Jonas Anderberg";

            //    jonasKonto.Balance = 36009;

            //    Console.WriteLine($"{jonasKonto.AccountName} tjänade {jonasKonto.Balance * BankAccount.InterestRate:C}");

            //    var sarabKonto = new BankAccount();

            //    sarabKonto.AccountName = "Sarab Kamali";

            //    sarabKonto.Balance = 24492;

            //    Console.WriteLine($"{sarabKonto.AccountName} tjänade {sarabKonto.Balance * BankAccount.InterestRate:C}");
            //    Console.WriteLine("\n\n");

            //    bang.WriteToConsole();

            //    Console.WriteLine(bang.GetOrigin());
            //    var fruitNamed = bang.GetNamedFruit();
            //    Console.WriteLine($"Det finns {fruitNamed.Number} {fruitNamed.Name}");

            //    var thing1 = ("Bruce", 1);

            //    Console.WriteLine($"{thing1.Item1} har {thing1.Item2} barn");

            //    var thing2 = (bang.Name, bang.Children.Count);
            //    Console.WriteLine($"{thing2.Name} har {thing2.Count} barn");


            //    //spara return värdet i en tuple variabel med två fält
            //    (string name, int age) tupleWithNamedFields = bang.GetPerson();
            //    // tupleWithNamedFields.name
            //    // tupleWithNamedFields.age

            //    (string name, int age) = bang.GetPerson();
            //    //age
            //    //name

            //    (string fruitName, int fruitNumber) = bang.GetNamedFruit();

            //    Console.WriteLine($"Deconstructed: {fruitName} {fruitNumber}");


            //    Console.WriteLine("\n\n");

            //    Console.WriteLine(bang.SayHello());

            //    Console.WriteLine(bang.SayHello("Obama"));

            //    Console.WriteLine(bang.OptionalParameters());
            //    Console.WriteLine(bang.OptionalParameters("But can you do this?", 399.99, true));
            //    Console.WriteLine(bang.OptionalParameters(command: "ELD", active: false, number: 2.0));
            //    Console.WriteLine(bang.OptionalParameters(command: "SIMMA", active: true));

            //    int a = 13;
            //    int b = 23;
            //    int c = 33;

            //    Console.WriteLine($"\n\nFöre: a = {a}, b = {b} och c = {c}");
            //    bang.PassingParameters(a, ref b, out c);
            //    Console.WriteLine($"Efter: a = {a}, b = {b} och c = {c}");

            var sammy = new Person
            {

                Name = "Sammy",
                DateOfBirth = new DateTime(1990, 04, 15)
            };

            Console.WriteLine(sammy.Origin);
            Console.WriteLine(sammy.Greeting);
            Console.WriteLine(sammy.Age);


            sammy.FavoriteIceCream = "Chokladglass";

            sammy.FavoritePrimaryColor = "Blue";

            Console.WriteLine($"Sammys favoritglass är {sammy.FavoriteIceCream} och hennes favoritfärg är {sammy.FavoritePrimaryColor}");

            sammy.Children.Add(new Person { Name = "Kalle" });

            sammy.Children.Add(new Person { Name = "Paul" });

            Console.WriteLine($"{sammy.Name} har {sammy.Children.Count} barn som heter {sammy.Children[0].Name} och {sammy.Children[1].Name}");

            object[] passengers =
            {
                new FirstClassPassenger {AirMiles = 1_419},
                new FirstClassPassenger {AirMiles = 16_512},
                new BusinessClassPassenger(),
                new CoachClassPassenger{ CarryOnKg = 2.31},
                new CoachClassPassenger {CarryOnKg = 23.2}
            };

            foreach (var passagerare in passengers)
            {
                decimal flightCost = passagerare switch
                {
                    ////C#8 Syntax
                    //FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
                    //FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
                    //FirstClassPassenger _ => 2000M,
                    //BusinessClassPassenger _ => 1000M,
                    //CoachClassPassenger p when p.CarryOnKg < 10.0 => 500M,
                    //CoachClassPassenger _ => 650M,
                    //_ => 800M

                    //C#9 Syntax
                    FirstClassPassenger p=> p.AirMiles switch
                    {
                        > 35000 => 1500M,
                        > 15000 => 1750M,
                         _ => 2000M
                    },

                   
                    BusinessClassPassenger _ => 1000M,
                    CoachClassPassenger p when p.CarryOnKg < 10.0 => 500M,
                    CoachClassPassenger _ => 650M,
                    _ => 800M
                };
                Console.WriteLine($"Flyget kosar {flightCost:C} för {passagerare}");
            }


            var jefferson = new ImmutablePerson
            {
                FirstName = "Jefferson",
                LastName = "Pierce"
            };

            //jefferson.FirstName = "Jeffe";

            var car = new ImmutableVehicle
            {
                Brand = "Volvo",
                Color = "Vit",
                Wheels = 4
            };

            var repaintedCar = car with { Color = "Grå" };

            Console.WriteLine($"Vanliga färgen är {car.Color} men byttes sedan tii {repaintedCar.Color}");

            var isac = new ImmutableAnimal2("Isac", "Chihuahua");

            var (who, what) = isac; //Kallas deconstruct metoden

            Console.WriteLine($"{who} är en {what}");
        }
    }
}
