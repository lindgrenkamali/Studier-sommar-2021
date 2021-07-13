using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary
{
   public class TextAndNumber
    {
        public string Text;

        public int Number;

    }

    public class Processor
    {
        public TextAndNumber GetTheData()
        {
            return new TextAndNumber
            {
                Text = "Vad är ens meningen med livet, lol?",
                Number = 21
            };
        }
    }
}
