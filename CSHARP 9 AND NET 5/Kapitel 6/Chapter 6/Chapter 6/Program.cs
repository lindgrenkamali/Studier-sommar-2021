using System;
using PacktLibrary.Shared;

namespace Chapter_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var hans = new Person { Name = "Hans" };
            //var maja = new Person { Name = "Maja" };
            var julia = new Person { Name = "Julia" };

            ////Kalla på en instans metod
            //var child1 = maja.ProCreateWith(hans);

            //child1.Name = "Gustav";

            ////Kalla på en statisk metod
            //var baby2 = Person.ProCreate(hans, julia);

            ////Kalla på en operator
            //var baby3 = hans * maja;

            //Console.WriteLine($"{hans.Name} har {hans.Children.Count} antal barn.");
            //Console.WriteLine($"{maja.Name} har {maja.Children.Count} antal barn.");
            //Console.WriteLine($"{julia.Name} har {julia.Children.Count} antal barn.");
            //Console.WriteLine($"{hans.Name} har ett barn som heter {hans.Children[0].Name}.");

            //Console.WriteLine($"5! är {Person.Factorial(5)}");
            //Console.WriteLine();
            //Console.WriteLine();


            //hans.Shout += Hans_Shout;

            //hans.Poke();
            //hans.Poke();
            //hans.Poke();
            //hans.Poke();

            Person[] people = {
                new Person { Name = "Simpan"},
                new Person { Name = "Robin" },
                new Person { Name = "Stefan" },
                new Person { Name = "Olof" }

            };

            //Console.WriteLine($"Lista av människor före sortering:");
            //foreach (var p in people)
            //{
            //    Console.WriteLine($"{p.Name}");
            //}

            //Array.Sort(people);
            //Console.WriteLine($"Lista av människor efter sortering:");
            //foreach (var p in people)
            //{
            //    Console.WriteLine($"{p.Name}");
            //}

            //Console.WriteLine("Använd PersonComparers IComparer implementation för att sortera:");
            //Array.Sort(people, new PersonComparer());

            //foreach (var p in people)
            //{
            //    Console.WriteLine($"{p.Name}");
            //}

            //var t1 = new Thing();
            //t1.Data = 38;

            //Console.WriteLine($"Sak med en int: {t1.Process(42)}");

            //var t2 = new Thing();
            //t2.Data = "päron";

            //Console.WriteLine($"Sak med en string: {t2.Process("päron")}");

            //var gt1 = new GenericThing<int>();
            //gt1.Data = 13;
            //Console.WriteLine($"GenericThing med en int: {gt1.Process(42)}");

            //var gt2 = new GenericThing<string>();
            //gt2.Data = "päron";
            //Console.WriteLine($"GenericThing med en string: {gt2.Process("päron")}");


            //string number1 = "3";

            //Console.WriteLine($"{number1} kvadraterad är {Squarer.Square<string>(number1)}");

            //byte number2 = 9;
            //Console.WriteLine($"{number2} kvadraterad är {Squarer.Square(number2)}");

            //var dv1 = new DisplacementVector(3, 15);
            //var dv2 = new DisplacementVector(13, 7);
            //var dv3 = dv1 + dv2;

            //Console.WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X} + {dv2.Y}) = ({dv3.X}, {dv3.Y}),");

            //Employee lina = new Employee { EmployeeCode = "LL002", Name = "Lina Lundgren", HireDate = new DateTime(2015, 01, 5), DateOfBirth = new DateTime(1992, 05, 14) };

            //lina.WriteToConsole();

            //lina.ToString();

            //Employee alfons = new Employee { Name = "Alfons", EmployeeCode = "AA626" };

            //Person alfonsIPerson = alfons;

            //alfons.WriteToConsole();
            //Console.WriteLine(alfons.ToString());

            //alfonsIPerson.WriteToConsole();
            //Console.WriteLine(alfonsIPerson.ToString());

            //if (alfonsIPerson is Employee)
            //{
            //    Console.WriteLine($"{nameof(alfonsIPerson)} är en anställd");
            //    Employee explicitAlfons = (Employee)alfonsIPerson;
            //}

            //Employee alfonsSomAnställd = alfonsIPerson as Employee;

            //if (alfonsSomAnställd != null)
            //{
            //    Console.WriteLine($"{nameof(alfonsSomAnställd)} som en anställd");
            //}

            //try
            //{
            //    lina.TimeTravel(new DateTime(1880, 12, 3));
            //}
            //catch(PersonException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            string email1 = "pablo@test.se";
            string email2 = "inting%test.se";

            Console.WriteLine($"{email1} är en gitlig e-post: {email1.IsValidEmail()}");
            Console.WriteLine($"{email2} är en gitlig e-post: {email2.IsValidEmail()}");

        }

        private static void Hans_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            Console.WriteLine($"{p.Name} är så här arg: {p.AngerLevel}");
        }
    }
}
