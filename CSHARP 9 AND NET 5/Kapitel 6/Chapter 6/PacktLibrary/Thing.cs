using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    public class Thing
    {
        public object Data = default(object);

        public string Process(object input)
        {
            if (Data == input)
            {
                return "Data och input är samma.";
            }

            else
            {
                return "Data och input är inte samma.";
            }
        }
    }
}
