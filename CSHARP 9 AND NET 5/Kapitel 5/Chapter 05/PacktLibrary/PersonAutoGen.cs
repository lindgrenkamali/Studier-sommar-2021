using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacktLibrary.Shared
{
    public class PersonAutoGen
    {
        
    }

    public partial class Person
    {
        //En property definerad i C# 1 till 5
        public string Origin
        {
            get
            {
                return $"{Name} är född på planeten {HomePlanet}";
            }
        }

        //två properties definerade med C# 6+ med lambda

        public string Greeting => $"{Name} säger 'Hej'";

        public int Age => System.DateTime.Today.Year - DateOfBirth.Year;

        public string FavoriteIceCream { get; set; } //auto-syntax
        private string favoritePrimaryColor;

        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set { Children[index] = value; }
        }

        public string FavoritePrimaryColor
        {
            get { return favoritePrimaryColor; }

            set
            {
                switch (value.ToLower())
                {
                    case "red":
                    case "green":
                    case "blue":
                        favoritePrimaryColor = value;
                        break;
                    default:
                        throw new System.ArgumentException
                        ($"{value} är inte en primärfärg. Välj antingen red, green eller blue");

                }
            }
        }

    }
}
