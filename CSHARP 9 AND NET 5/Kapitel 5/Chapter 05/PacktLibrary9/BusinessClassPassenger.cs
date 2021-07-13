using System;

namespace PacktLibrary.Shared
{
    public class BusinessClassPassenger
    {
        public override string ToString()
        {
            return $"Business Class";
        }

    }

    public class FirstClassPassenger
    {
        public int AirMiles { get; set; }

        public override string ToString()
        {
            return $"Första klass med {AirMiles:N0} luft mil";
        }
    }

        public class CoachClassPassenger
        {
            public double CarryOnKg { get; set; }

            public override string ToString()
            {
                return $"Coach Klass med {CarryOnKg:N2} KG vikt";
            }
        }
    }
