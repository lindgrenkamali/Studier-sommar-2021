using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
   public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            //Jämför namn längderna
            int result = x.Name.Length.CompareTo(y.Name.Length);

            if (result == 0)
            {
                //sen jämför namnen
                return x.Name.CompareTo(y.Name);
            }

            else
            {
                //.....annars jämför längden
                return result;
            }
        }
    }
}

