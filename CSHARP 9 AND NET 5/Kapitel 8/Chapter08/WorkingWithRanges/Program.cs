using System;

namespace WorkingWithRanges
{
    class Program
    {
        static void Main(string[] args)
        {
            TryingRanges();
        }

        private static void TryingRanges()
        {
            string name = "Kanye West";

            int lengthOfFirst = name.IndexOf(" ");
            int lengthOfLast = name.Length - lengthOfFirst - 1;

            string firstName = name.Substring(startIndex: 0, lengthOfFirst);

            string lastName = name.Substring(startIndex: name.Length - lengthOfLast, length: lengthOfLast);

            Console.WriteLine($"Förnamn: {firstName} och efternamn: {lastName}");

            ReadOnlySpan<char> nameAsSpan = name.AsSpan();
            var firstNameSpan = nameAsSpan[0..lengthOfFirst];

            var lastNameSpan = nameAsSpan[^lengthOfLast..^0];
            Console.WriteLine($"Förnamn: {firstNameSpan.ToString()} och efternamn: {lastNameSpan.ToString()}");
        }
    }
}
