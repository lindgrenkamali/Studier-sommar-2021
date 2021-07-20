using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    public class GenericThing<T> where T: IComparable
    {
        public T Data = default(T);

        public string Process(T input)
        {
            if (Data.CompareTo(input) == 0)
            {
                return "Data och input är desamma.";
            }

            else
            {
                return "Data och input är inte desamma.";
            }
        }
    }
}
