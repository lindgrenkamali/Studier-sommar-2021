using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    public class Employee : Person
    {
        public string EmployeeCode { get; set; }
        public DateTime HireDate { get; set; }


        public new void WriteToConsole()
        {
            Console.WriteLine($"{Name} var född {DateOfBirth:dd/MM/yy} och anställd {HireDate:dd/MM/yy}");
        }

        public override string ToString()
        {
            return $"{Name}s kod är {EmployeeCode}";
        }
    }
}
