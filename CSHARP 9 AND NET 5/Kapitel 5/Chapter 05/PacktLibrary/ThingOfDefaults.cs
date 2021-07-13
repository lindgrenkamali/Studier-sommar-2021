using PacktLibrary.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary
{
    class ThingOfDefaults
    {
        public int Population;

        public DateTime When;

        public string Name;

        public List<Person> People;

        public ThingOfDefaults()
        {
            //Population = default(int);
            //When = default(DateTime);
            //Name = default(string);
            //People = default(List<Person>);

            Population = default;
            When = default;
            Name = default;
            People = default;
        }
    }
}
