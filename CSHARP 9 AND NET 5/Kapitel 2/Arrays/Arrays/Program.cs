using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn; //Kan referera vilken array som helst av stringar

            //Allokerar minne för fyra strängar i en array
            namn = new string[4];

            //Lägger till items på index positioner
            namn[0] = "Fredrik";
            namn[1] = "David";
            namn[2] = "Johan";
            namn[3] = "Nils";

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine(namn[i]);
            }
        }
    }
}
