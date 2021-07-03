using System;

namespace WritingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            //RunTimesTable();
            // RunCalculateTax();


            //RunCardinalToOrdinal();

            //RunFactorial();

            RunFibFunctional();
        }


        static void RunFibImperative()
        {
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Termen {0} av fibonacci koden är {1:N0}", arg0: CardinalToOrdinal(i), arg1: FibImperative(term: i));
            }
        }

        static void RunFibFunctional()
        {
            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Termen {0} av fibonacci koden är {1:N0}", arg0: CardinalToOrdinal(i), arg1: FibFunctional(term: i));
            }
        }

        static int FibFunctional(int term) =>
            term switch
            {
                1 => 0,
                2 => 1,
                _ => FibFunctional(term - 1) + FibFunctional(term - 2)
            };

        static int FibImperative(int term)
        {
            if (term == 1)
            {
                return 0;
            }
            else if (term == 2)
            {
                return 1;
            }
            else
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        static void RunFactorial()
        {
            for (int i = 0; i < 15; i++)
            {
                try
                {

                    Console.WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (System.OverflowException)
                {

                    Console.WriteLine($"{i}! är för stort för en 32 bitars int");
                }
            }
        }

        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 0;
            }
            else if (number == 1)
            {
                return 1;
            }
            else
            {
                checked
                {
                    return number * Factorial(number - 1);
                }
            }
        }

        private static void RunCardinalToOrdinal()
        {
            for (int number = 0; number <= 40; number++)
            {
                Console.Write($"{CardinalToOrdinal(number)} ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Passar en 32-bitars int som blir konverterad till en ordinal equivalent
        /// </summary>
        /// <param name="number"> Number är en cardinal value t.ex 1, 2 och 3</param>
        /// <returns> Number som ett ordinal värde t.ex första, andra och tredje</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11: //Speciala case för nummer mellan 11-13
                case 12:
                case 13:
                    return $"{number}th";

                default:
                    int lastDigit = number % 10;


                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Console.WriteLine("Skriv in ett nummer mellan 0 till 255");

                isNumber = byte.TryParse(Console.ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTable(number);
                }

                else
                {
                    Console.WriteLine("Du skrev ej in ett gitligt nummer");
                }
            } while (isNumber);

            RunCalculateTax();
        }

        static void RunCalculateTax()
        {
            Console.Write("Skriv in ett värde: ");
            string amountInText = Console.ReadLine();
            Console.Write("Skriv in ett två-bokstav region kod: ");
            string region = Console.ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                Console.WriteLine($"Du måste betala {taxToPay} i skatt");
            }

            else
            {
                Console.WriteLine("Du skrev ej in ett gitligt värde");
            }
        }

        static void TimesTable(byte number)
        {
            Console.WriteLine($"Det här är {number}:ans gångertabell: ");
            for (int row = 0; row < 12; row++)
            {
                Console.WriteLine($"{row} x {number} = {row * number}");

            }
            Console.WriteLine();
        }

        static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
        {
            decimal rate = 0.0M;

            switch (twoLetterRegionCode)
            {
                case "CH": //Switzerland
                    rate = 0.08M;
                    break;
                case "DK": //Danmark
                case "NO": //Norge
                    rate = 0.25M;
                    break;
                case "GB": //Storbritannien
                case "FR": //Frankrike
                    rate = 0.2M;
                    break;
                case "HU": //Hungary
                    rate = 0.27M;
                    break;

                case "OR": //Oregon
                case "AK": //Alaska
                case "MT": //Montana
                    rate = 0.0M;
                    break;

                case "WI": //Wisconsin
                case "ME": //MaryLand
                case "VA": //Virginia
                case "ND": //North Dakota
                    rate = 0.05M;
                    break;

                case "CA": //California
                    rate = 0.0825M;
                    break;



                default: //Flesta us staterna
                    rate = 0.06M;
                    break;
            }
            return amount * rate;
        }
    }
}
