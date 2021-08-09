using System.Reflection;
using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace WorkingWithReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAttributes();
            
        }

        

        [Coder("David Lindgren Kamali", "09 Augusti 2021")]
        [Coder("Happy", "21 April 2013")]
        private static void DoStuff()
        {
           

        }

        private static void GetAttributes()
        {
            Console.WriteLine("Assembly metadata:");
            Assembly assembly = Assembly.GetEntryAssembly();

            Console.WriteLine($"Fullständiga namn: {assembly.FullName}");
            Console.WriteLine($"Plats: {assembly.Location}");



            var attributes = assembly.GetCustomAttributes();

            Console.WriteLine($"Attributes:");
            foreach (Attribute att in attributes)
            {
                Console.WriteLine($"{att.GetType()}");
            }

            var version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();

            Console.WriteLine();
            Console.WriteLine($"Version: {version.InformationalVersion}");

            var company = assembly.GetCustomAttribute<AssemblyCompanyAttribute>();

            Console.WriteLine($"Företaget: {company.Company}");

            Console.WriteLine();
            Console.WriteLine($"*Typer:");
            Type[] types = assembly.GetTypes();

            foreach (Type type in types)
            {
                Console.WriteLine($"\nTyp: {type.FullName}");
                MemberInfo[] members = type.GetMembers();

                foreach (MemberInfo member in members)
                {
                    Console.WriteLine($"{member.MemberType}: {member.Name} {member.DeclaringType.Name}");

                    var coders = member.GetCustomAttributes<CoderAttribute>().OrderByDescending(c => c.LastModified);

                    foreach (CoderAttribute coder in coders)
                    {
                        Console.WriteLine($"-> Modifierad av {coder.Coder} på {coder.LastModified.ToShortDateString()}");
                    }
                }
            }
        }
    }
}
